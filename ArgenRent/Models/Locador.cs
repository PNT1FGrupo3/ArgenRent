﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgenRent.Models
{
    public class Locador : Usuario
    {
        public virtual Propiedad propiedad {  get; set; }
    }
}
