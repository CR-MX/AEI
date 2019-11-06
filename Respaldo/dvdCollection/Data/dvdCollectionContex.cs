using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;
using dvdCollection.Controllers;

namespace dvdCollection.Controllers
{
    public class dvdCollectionContex : DbContext
    {
        public dvdCollectionContex(DbContextOptions<dvdCollectionContex> options):base(options){

        }
        public DbSet<Actors> Actors {get;set;}
        public DbSet<FilmCertificates> FilmCertificates {get;set;}
        public DbSet<FilmGeneres> FilmGeneres {get;set;}
        public DbSet<FilmsActorRoles> FilmsActorRoles {get;set;}
        public DbSet<FilmTitles> FilmTitles {get;set;}
        public DbSet<FilmTitlesProducers> FilmTitlesProducers {get;set;}
        public DbSet<Producers> Producers {get;set;}
        public DbSet<RoleTypes> RoleTypes {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<FilmTitlesProducers>().HasKey(c => new {c.ProducersID, c.FilmTitlesID});
            modelBuilder.Entity<FilmsActorRoles>().HasKey(c => new {c.FilmTitleID, c.ActorID, c.RoleTypeID});
        
        }
    }
}
