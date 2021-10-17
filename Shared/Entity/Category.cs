using System;
using System.ComponentModel.DataAnnotations;
using blazorProyI.Shared.Entity;
using System.Collections.Generic;

namespace blazorProyI.Shared.Entity
{
    public class Category
    {
        public int Id{get;set;}
        /* Validamos que el campo nombre es requerido */
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name{get;set;}
        public List <CategoryMovie> CategoriesMovie {get;set;}
    }
}