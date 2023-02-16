using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosDeFixação3
{
    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private DateTime datanascimento;
        private string telefone;
        private string email;
        public override string ToString()
        {
            return Nome + " " + Sobrenome;
        }
        public string Nome 
        { 
            get { return nome; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DataNascimento
        {
            get { return datanascimento; }
        }

        public Pessoa(string nome, string sobrenome,
            DateTime dtNascimento, string telefone, string email)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.datanascimento = dtNascimento;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
