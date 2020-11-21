using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountWebMVC.Models.ViewModels
{
    public class LocalFormViewModel
    {
        public Local Local { get; set; }
        public ICollection<Tipo> Tipo{ get; set; }
    }
}
