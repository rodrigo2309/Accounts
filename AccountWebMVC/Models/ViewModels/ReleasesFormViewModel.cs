using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountWebMVC.Models.ViewModels
{
    public class ReleasesFormViewModel
    {
        public Release Release { get; set; } 
        public ICollection<Local> Local { get; set; }
    }
}
