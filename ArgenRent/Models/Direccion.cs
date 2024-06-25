using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Spatial;

namespace ArgenRent.Models
{
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID {  get; set; }

        [Required(ErrorMessage = "Debe especificar la Calle")]
        public string calle { get; set; }

        [Required(ErrorMessage = "Debe especificar la Altura")]
        [Range(1, 10000, ErrorMessage = "La altura debe ser de 1 a 10000")]
        public int altura { get; set; }

        [Required(ErrorMessage = "Debe especificar el Piso")]
        [Range(1, 10000, ErrorMessage = "El piso debe ser de 1 a 100")]
        public int piso {  get; set; }

        [Required(ErrorMessage = "Debe especificar el Departamento")]
        public string departamento { get; set; }

        [Required(ErrorMessage = "Debe especificar la Localidad")]
        public string localidad { get; set; }

        [Required(ErrorMessage = "Debe especificar el Pais")]
        public string pais { get; set; }
    }
}
