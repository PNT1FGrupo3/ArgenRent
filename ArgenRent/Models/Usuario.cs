using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgenRent.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public double rating { get; set; }
    }
}
