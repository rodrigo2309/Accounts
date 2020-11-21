using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace AccountWebMVC.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Tipo()
        {

        }

        public Tipo(int id,string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
