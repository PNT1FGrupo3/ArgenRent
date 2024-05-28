using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_3_PNT1.Context
{
    public class ArgenRentDatabaseContext : DbContext
    {
        public ArgenRentDatabaseContext(DbContextOptions<ArgenRentDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }



    }
}
