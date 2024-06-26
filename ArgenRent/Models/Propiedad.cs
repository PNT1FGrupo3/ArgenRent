﻿using Microsoft.CodeAnalysis.Options;
using Newtonsoft.Json.Linq;
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

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Debe especificar el titulo")]
        public string titulo { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Debe especificar la descripcion")]
        public string descripcion { get; set; }

        [Display(Name = "$ Noche")]
        [Required(ErrorMessage = "Debe especificar el precio por noche")]
        [Range(1.0, 9999999999, ErrorMessage = "El precio por noche debe ser mayor a 0")]
        public double precioPorNoche { get; set; }

        [Display(Name = "PetFriendly")]
        [Required(ErrorMessage = "Debe especificar si se aceptan mascotas")]
        public bool aceptaMascotas { get; set; }

        [Display(Name = "Ambientes")]
        [Required(ErrorMessage = "Debe especificar la cantidad de ambientes")]
        [Range(1, 9999999999, ErrorMessage = "La cantidad de ambientes debe ser mayor a 0")]
        public int cantidadAmbientes { get; set; }

        [Display(Name = "Dormitorios")]
        [Required(ErrorMessage = "Debe especificar la cantidad de dormitorios")]
        [Range(1, 9999999999, ErrorMessage = "La cantidad de dormitorios debe ser mayor a 0")]
        public int cantidadDormitorios { get; set; }

        [Display(Name = "Baños")]
        [Required(ErrorMessage = "Debe especificar la cantidad de baños")]
        [Range(1, 9999999999, ErrorMessage = "La cantidad de baños debe ser mayor a 0")]
        public int cantidadBanios { get; set; }

        [Display(Name = "M² Cubiertos")]
        [Required(ErrorMessage = "Debe especificar la cantidad de m2 cubiertos")]
        [Range(1, 9999999999, ErrorMessage = "La cantidad de m2 cubiertos debe ser mayor a 0")]
        public int cantidadM2Cubiertos { get; set; }

        [Display(Name = "M² Descubiertos")]
        [Required(ErrorMessage = "Debe especificar la cantidad de m2 descubiertos")]
        [Range(1, 9999999999, ErrorMessage = "La cantidad de m2 descubiertos debe ser mayor a 0")]
        public int cantidadM2Descubiertos { get; set; }

        [Display(Name = "Cocheras")]
        [Required(ErrorMessage = "Debe especificar la cantidad de cocheras")]
        [Range(0, 9999999999, ErrorMessage = "La cantidad de cocheras no puede ser negativa")]
        public int cantidadCocheras { get; set; }

        [Display(Name = "Ranking")]
        [Required(ErrorMessage = "Debe especificar el Rating")]
        [Range(1, 10, ErrorMessage = "El Rating debe ser de 1 a 10")]
        public double ranking {  get; set; }

        [Display(Name = "Usuario")]
        public int? UsuarioId { get; set; }
        //public int? DireccionId { get; set; }

        [Display(Name = "Tipo de Propiedad")]
        [EnumDataType(typeof(TipoPropiedad))]
        public TipoPropiedad tipoPropiedad { get; set; }

        [Display(Name = "Usuario")]
        public virtual Usuario? usuario { get; set; }
        //public virtual Direccion direccion { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe especificar la direccion")]
        public string direccion { get; set; }

       
    }



    /*  titulo
        ranking
        usuario
        direccion
        UsuarioId
        descripcion
        tipoPropiedad
        aceptaMascotas
        cantidadBanios
        precioPorNoche
        cantidadCocheras
        cantidadAmbientes
        cantidadDormitorios
        cantidadM2Cubiertos
        cantidadM2Descubiertos*/



}

/*<select asp-for="tipoPropiedad" class="form-control" asp-items="Html.GetEnumSelectList<TipoPropiedad>()">
                    < option selected = "selected" value = "" > Por favor seleccionar</option>
                </select>*/