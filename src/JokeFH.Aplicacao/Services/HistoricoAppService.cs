using System.Collections.Generic;
using AutoMapper;
using JokeFH.Aplicacao.Interface;
using JokeFH.Aplicacao.ViewModels;
using JokeFH.Dominio.Entities;
using JokeFH.Dominio.Interface.Service;

namespace JokeFH.Aplicacao.Services
{
    public class HistoricoAppService : IHistoricoAppService
    {
        private readonly IMapper _mapper;
        private readonly IHistoricoService _historicoService;

        public HistoricoAppService(IMapper mapper, IHistoricoService historicoService)
        {
            _mapper = mapper;
            _historicoService = historicoService;
        }

        public void Adicionar(HistoricoViewModel historicoView)
        {
            var historico = _mapper.Map<Historico>(historicoView);
            _historicoService.Add(historico);
        }

        public IEnumerable<HistoricoViewModel> ObterPorJogador(string jogador)
        {
            return _mapper.Map<IEnumerable<HistoricoViewModel>>(_historicoService.ObterPorJogador(jogador));
        }
    }
}