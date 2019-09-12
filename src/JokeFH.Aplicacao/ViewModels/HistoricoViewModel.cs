using System;

namespace JokeFH.Aplicacao.ViewModels
{
    public class HistoricoViewModel
    {
        public Guid Id { get; set; }
        public string Jogador { get; set; }
        public DateTime DataHora { get; set; }
        public string Vencedor { get; set; }
    }
}