using System;
using System.ComponentModel.DataAnnotations;
namespace blazorProyI.Shared.Entity
{
    public class Category
    {
        public int Id{get;set;}
        /* Validamos que el campo nombre es requerido */
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name{get;set;}
    }
}