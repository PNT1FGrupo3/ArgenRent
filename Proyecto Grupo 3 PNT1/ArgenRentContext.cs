using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_3_PNT1
{
    public class ArgenRentContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alquiler> Alquileres { get; set;}
        public DbSet<Propiedad> Propiedades { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ArgenRentDB;Trusted_Connection=True;");
        }   



    }
}
