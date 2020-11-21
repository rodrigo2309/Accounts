using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountWebMVC.Models
{
    public class Local
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public int TipoID { get; set; }

        public Local()
        {

        }

        public Local(int id, string nome, Tipo tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }
    }
}
