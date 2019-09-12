using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using JokeFH.Dominio.Entities;
using JokeFH.Dominio.Interface.Repository;

namespace JokeFH.Infra.Data.Repository
{
    public class HistoricoRepository : RepositoryBase, IHistoricoRepository
    {
        public void Adicionar(Historico entity)
        {
            var sql = "Insert Into Historicos(Id, Jogador, DataHora, Vencedor) values (@Id, @Jogador, @DataHora, @Vencedor)";

            var parans = new DynamicParameters();
            parans.Add("@Id", entity.Id);
            parans.Add("@Jogador", entity.Jogador);
            parans.Add("@DataHora", entity.DataHora);
            parans.Add("@Vencedor", entity.Vencedor);
            
            using (var conn = Connection)
            {
                conn.Open();
                conn.Query(sql, parans);
                conn.Close();
            }
        }

        public Historico GetById(Guid id)
        {
            var sql = "Select * From Historicos Where id = @id";
            using (var conn = Connection)
            {
                conn.Open();
                var historico = conn.Query<Historico>(sql, new { id }).FirstOrDefault();
                conn.Close();

                return historico;
            }
        }

        public IEnumerable<Historico> ObterPorJogador(string jogador)
        {
            var sql = "Select * From Historicos Where Jogador Like @jogador";
            using (var conn = Connection)
            {
                conn.Open();
                var historicos = conn.Query<Historico>(sql, new {jogador});
                conn.Close();

                return historicos;
            }
        }
    }
}