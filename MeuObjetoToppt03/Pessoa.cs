using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MeuObjetoToppt03
{
    internal class Pessoa
    {
        private string nome;
        private string cpf;
        private int idade;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        
        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }


    }
}
