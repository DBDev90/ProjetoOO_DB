using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOO_DB
{
    public class Pessoa
    {
        private int Id;
        private string Nome;
        private string Telefone;

        public Pessoa(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setId(int id)
        {
            Id = id;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        } 
    }
}
