using CitasMedicas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace CitasMedicas.Data
{
    public class CitasContext : IdentityDbContext<User>
    {
        public CitasContext(DbContextOptions<CitasContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Registro> Registros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Paciente>().ToTable("Paciente");
            modelBuilder.Entity<Recepcionista>().ToTable("Recepcionista");

            modelBuilder.Entity<Receta>().ToTable("Receta");
            modelBuilder.Entity<Registro>().ToTable("Registro");
        }
    }
}