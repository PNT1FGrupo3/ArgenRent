using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ArgenRent.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID {  get; set; }

        [Required(ErrorMessage = "Debe especificar el Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe especificar el Apellido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "Debe especificar el Usuario")]
        public string usuario { get; set; }


        [Display(Name = "Contraseña")]
        [DataType(DataType.Password, ErrorMessage = "Debe especificar la Contraseña")]
        [Required(ErrorMessage = "Debe especificar la Contraseña")]
        public string contrasenia { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Debe ingresar un email valido")]
        [Required(ErrorMessage = "Debe especificar el Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Debe ingresar un email valido")]
        public string email { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Debe ingresar un telefono valido")]
        [Required(ErrorMessage = "Debe especificar el Telefono")]
        public string telefono { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}")]
        [Required(ErrorMessage = "Debe especificar el Rating")]
        [Range(1, 10, ErrorMessage = "El Rating debe ser de 1 a 10")]
        public double rating { get; set; }
    }
}
