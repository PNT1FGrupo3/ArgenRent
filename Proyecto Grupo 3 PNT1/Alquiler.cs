using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_3_PNT1
{
    internal class Alquiler
    {
        public int ID { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaSalida { get; set; }
        public Propiedad propiedad { get; set; }
        public Locatario locatario { get; set; }

    }
}
