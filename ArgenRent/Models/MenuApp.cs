using ArgenRent.Models;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgenRent.Models
{
    public class MenuApp
    {

        public ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
        public ICollection<Propiedad> Propiedades { get; } = new List<Propiedad>();
        public ICollection<Alquiler> Alquileres { get; } = new List<Alquiler>();

        public MenuApp()
        {
        
        }
    }
}
