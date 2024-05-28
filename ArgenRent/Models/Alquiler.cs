using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgenRent.Models
{
    public class Alquiler
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //[Display(Name = "Fecha de Inicio")]
        public DateTime fechaInicio { get; set; }

        //[Display(Name = "Fecha de Salida")]
        public DateTime fechaSalida { get; set; }
        public Propiedad propiedad { get; set; }
        public Locatario locatario { get; set; }

    }
}
