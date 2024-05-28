﻿using ArgenRent.Models;
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
        public List<Usuario> usuarios;
        public List<Propiedad> propiedades;
        public List<Alquiler> alquileres;

        public MenuApp()
        {
            usuarios = new List<Usuario>();
            propiedades = new List<Propiedad>();
            alquileres = new List<Alquiler>();
        }
    }
}
