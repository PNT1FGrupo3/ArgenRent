using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Spatial;

namespace Proyecto_Grupo_3_PNT1
{
    internal class Direccion
    {
        public int ID {  get; set; }
        public GeographyPoint ubicacion {  get; set; }
        public string calle { get; set; }
        public int altura { get; set; }
        public int piso {  get; set; }
        public string departamento { get; set; }
        public string localidad { get; set; }
        public string pais { get; set; }

    }
}
