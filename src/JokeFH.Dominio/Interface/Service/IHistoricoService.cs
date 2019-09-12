using System.Collections.Generic;
using JokeFH.Dominio.Entities;

namespace JokeFH.Dominio.Interface.Service
{
    public interface IHistoricoService : IServiceBase<Historico>
    {
        IEnumerable<Historico> ObterPorJogador(string jogador);
    }
}