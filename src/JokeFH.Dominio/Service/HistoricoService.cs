using System;
using System.Collections.Generic;
using JokeFH.Dominio.Entities;
using JokeFH.Dominio.Interface.Repository;
using JokeFH.Dominio.Interface.Service;

namespace JokeFH.Dominio.Service
{
    public class HistoricoService: IHistoricoService
    {
        private readonly IHistoricoRepository _historicoRepository;

        public HistoricoService(IHistoricoRepository historicoRepository)
        {
            _historicoRepository = historicoRepository;
        }

        public void Add(Historico obj)
        {
            _historicoRepository.Adicionar(obj);
        }

        public Historico GetById(Guid id)
        {
            return _historicoRepository.GetById(id);
        }

        public IEnumerable<Historico> ObterPorJogador(string jogador)
        {
            return _historicoRepository.ObterPorJogador(jogador);
        }
    }
}