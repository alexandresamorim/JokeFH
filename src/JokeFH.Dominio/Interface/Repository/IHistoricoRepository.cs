using System.Collections.Generic;
using JokeFH.Dominio.Entities;

namespace JokeFH.Dominio.Interface.Repository
{
    public interface IHistoricoRepository : IRepositoryBase<Historico>
    {
        IEnumerable<Historico> ObterPorJogador(string jogador);
    }
}