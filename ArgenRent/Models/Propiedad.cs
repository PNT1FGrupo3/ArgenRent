using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgenRent.Models
{
    public class Propiedad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public double precioPorNoche { get; set; }
        public bool aceptaMascotas { get; set; }
        public int cantidadAmbientes { get; set; }
        public int cantidadDormitorios { get; set; }
        public int cantidadBanios { get; set; }
        public int cantidadM2Cubiertos { get; set; }
        public int cantidadM2Descubiertos { get; set; }
        public int cantidadCocheras { get; set; }
        public double ranking {  get; set; }
        public Direccion direccion { get; set; }

        [EnumDataType(typeof(TipoPropiedad))]
        public TipoPropiedad tipoPropiedad { get; set; }
        public Locador locador { get; set; }
    }
}