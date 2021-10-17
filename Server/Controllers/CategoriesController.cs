using System.Globalization;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using blazorProyI.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace blazorProyI.Server.Controllers
{
    
    
     [ApiController]
    
        [Route("api/[controller]")]
        
        public class CategoriesController : ControllerBase
           
        {
             public readonly ApplicationDbContext context;
             public CategoriesController(ApplicationDbContext context){
                 this.context = context; 
                 
                 
             }           
               
                [HttpPost]
                 public async Task<ActionResult<int>> Post(Category category){
                context.Add(category);
                await context.SaveChangesAsync();
                return category.Id;
            
        }
    }
}
  