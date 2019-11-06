using System.Linq;
using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;

namespace dvdCollection.Date
{
    public static class DbInitializer{
        public static void Initializate(dvdCollectionContext context){
            context.Database.EnsureCreated(); //c rea un Bd si no exite

            if(context.filmGeneres.Any()){
                return; //la base de dats ya tiene datos 

            }
            // arreglo de tipo film generes 
            var FilmGeneres = new FilmGeneres[]{
                new FilmGeneres{GenreDesc="Action"},
                new FilmGeneres{GenreDesc="Aventure"},
                new FilmGeneres{GenreDesc="Animation"},
                new FilmGeneres{GenreDesc="biograpy"},
                new FilmGeneres{GenreDesc="Comedy"},
                new FilmGeneres{GenreDesc="Crime"}
                new FilmGeneres{GenreDesc="Drama"}
                new FilmGeneres{GenreDesc="Family"}
                new FilmGeneres{GenreDesc="Fantasy"}
                new FilmGeneres{GenreDesc="History"}
            };
            foreach(FilmGeneres g in FilmGeneres){
                context.filmGeneres.add(g);
            }
            context.SaveChanges();


        }

    }
}