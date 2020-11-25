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

        public ICollection<Release> Releases { get; set; } = new List<Release>();

        public Local()
        {

        }
        public Local(int id, string nome, Tipo tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Releases.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Valor);
        }


    }
}
