
using System;

namespace AccountWebMVC.Models
{
    public class Release
    {
        public int Id { get; set; }
        public int Local { get; set; }   
        public double Valor { get; set; }
        public int Tipo { get; set; }
        public DateTime Data { get; set; }

        public Release()
        {

        }
        public Release(int id, int local, double valor, int tipo, DateTime data)
        {
            Id = id;
            Local = local;
            Valor = valor;
            Tipo = tipo;
            Data = data;
        }
    }
}
