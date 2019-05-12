using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treinamento.webapi.Models
{
    public class Reserva
    {
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public Pessoa Pessoa { get; set; }
        public ItemReserva ItemReserva { get; set; }
    }
}
