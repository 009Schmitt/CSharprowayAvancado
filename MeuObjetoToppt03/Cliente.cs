using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuObjetoToppt03
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        private string[] consultas;

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

        public string[] GetConsultas()
        {
            return consultas;
        }

        public void SetConsultas(string[] consultas)
        {
            this.consultas = consultas;
        }

    }
}
