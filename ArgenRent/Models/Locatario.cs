using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgenRent.Models
{
    public class Locatario : Usuario
    {
        public virtual Alquiler alquiler { get; set; }
    }
}
