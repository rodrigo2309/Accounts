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

        public ICollection<Local> Local { get; set; } = new List<Local>();

        public Tipo()
        {

        }

        public Tipo(int id,string nome)
        {
            Id = id;
            Nome = nome;
        }

        //public double TotalSales(DateTime initial, DateTime final)
        //{
        //    return Releases.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Valor);
        //}
    }
}
