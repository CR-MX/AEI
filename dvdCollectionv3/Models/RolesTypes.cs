using System.Collections.Generic;

namespace dvdCollection.Models{
    public class RolesTypes
    {
        public int RolTypeID{get; set;}
        public string RolDesc{get; set;}
        

        public ICollection <FilmsActorRoles> FilmActorRole {get; set;}
        
    }
}