using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treinamento.webapi.Models
{
    public class Sala : ItemReserva
    {
        public string Descricao { get; set; }
        public int Capacidade { get; set; }
    }
}
