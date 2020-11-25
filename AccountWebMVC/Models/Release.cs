
using System;
using System.ComponentModel.DataAnnotations;

namespace AccountWebMVC.Models
{
    public class Release
    {
        public int Id { get; set; }
        public Local Local { get; set; }        
        public int LocalID { get; set; }  
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        //[Required]
        //ApplyFormatInEditMode = true,
        //, ErrorMessage = "Data zuada"
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
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
