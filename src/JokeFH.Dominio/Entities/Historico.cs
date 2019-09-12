using System;

namespace JokeFH.Dominio.Entities
{
    public class Historico
    {
        public Guid Id { get; set; }
        public string Jogador { get; set; }
        public DateTime DataHora { get; set; }
        public string Vencedor { get; set; }
    }
}