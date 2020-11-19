
using System;

namespace AccountWebMVC.Models
{
    public class Release
    {
        public int Id { get; set; }
        public Local Local { get; set; }        
        public int LocalID { get; set; }        
        public double Valor { get; set; }        
        public DateTime Data { get; set; }
        
        public Release()
        {

        }
        public Release(int id, Local local, double valor, DateTime data)
        {
            Id = id;
            Local = local;
            Valor = valor;
            Data = data;
        }
    }
}
