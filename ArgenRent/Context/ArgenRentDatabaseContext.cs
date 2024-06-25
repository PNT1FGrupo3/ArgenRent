using ArgenRent.Models;
using Microsoft.EntityFrameworkCore;

namespace ArgenRent.Context
{
    public class ArgenRentDatabaseContext : DbContext
    {

        public ArgenRentDatabaseContext(DbContextOptions<ArgenRentDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }


    }
}
