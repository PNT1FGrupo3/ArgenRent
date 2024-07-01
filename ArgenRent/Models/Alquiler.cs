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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Fecha de Inicio")]
        public DateTime fechaInicio { get; set; }

        [Display(Name = "Fecha de Salida")]
        public DateTime fechaSalida { get; set; }

        [Display(Name = "Propiedad")]
        public int? PropiedadId { get; set; }

        [Display(Name = "Usuario")]
        public int? UsuarioId { get; set; }

        [Display(Name = "Propiedad")]
        public virtual Propiedad? propiedad { get; set; }

        [Display(Name = "Usuario")]
        public virtual Usuario? usuario { get; set; }

    }
}
