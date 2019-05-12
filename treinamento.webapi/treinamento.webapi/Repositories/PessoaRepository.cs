using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using treinamento.webapi.Models;

namespace treinamento.webapi.Repositories
{
    public static class PessoaRepository
    {
        private static List<Pessoa> Pessoas = new List<Pessoa>();

        public static void AdicionarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public static List<Pessoa> RetornarPessoas()
        {
            return Pessoas;
        }

        public static Pessoa RetornarPessoa(int id)
        {
            foreach (var pessoa in Pessoas)
                if (pessoa.ID == id)
                    return pessoa;

            return null;
        }

        public static Pessoa AtualizarPessoa(int id, Pessoa novaPessoa)
        {
            var pessoa = RetornarPessoa(id);
            if (pessoa == null)
                return null;
            
            var localidade = Pessoas.IndexOf(pessoa);
            Pessoas[localidade] = novaPessoa;

            return Pessoas[localidade];
        }
    }
}
