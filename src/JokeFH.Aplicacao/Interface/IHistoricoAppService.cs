using System.Collections.Generic;
using JokeFH.Aplicacao.ViewModels;

namespace JokeFH.Aplicacao.Interface
{
    public interface IHistoricoAppService
    {
        void Adicionar(HistoricoViewModel historicoView);
        IEnumerable<HistoricoViewModel> ObterPorJogador(string jogador);

    }
}