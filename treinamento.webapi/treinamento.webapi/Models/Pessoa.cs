using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treinamento.webapi.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
        public string Email { get; set; }
    }
}
