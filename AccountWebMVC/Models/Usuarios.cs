using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountWebMVC.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Ativo { get; set; }

        public Usuarios()
        {

        }
        public Usuarios(int id, string nome, string senha, int ativo)
        {
            this.id = id;
            Nome = nome;
            Senha = senha;
            Ativo = ativo;
        }
    }
}
