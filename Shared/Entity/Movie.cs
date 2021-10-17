using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System;
using blazorProyI.Shared.Entity;
using System.Collections.Generic;
namespace blazorProyI.Shared.Entity
{
    public class Movie
    {
        
        public int Id {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string Name {get;set;}
        public bool EnCartelera{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string MovieImage {get;set;}
        public string Sinopsis {get;set;}
        public string Poster {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public int Score {get;set;}
        public DateTime Premier {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public int MovieId {get;set;}
        public string Trailer {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public List <CategoryMovie> CategoriesMovie {get;set;} = new List <CategoryMovie> ();
        public List <MovieActor> MovieActor {get;set;}

        
        public string ShortName
        {
            get{
                if(string.IsNullOrWhiteSpace(Name))
                {
                    return null;
                }
                if(Name.Length > 60){
                    return Name.Substring(0,60) + "...";
                }else{
                    return Name;
                }
            }
        }
        
    }
}
    