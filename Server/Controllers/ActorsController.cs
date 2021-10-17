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
using blazorProyI.Server.Storage;
namespace blazorProyI.Server.Controllers
{
    
    
     [ApiController]
    
        [Route("api/[controller]")]
        
        public class ActorsController : ControllerBase
           
        {
             private readonly ApplicationDbContext context;
             private readonly IFileStorage FileStorage;
             private readonly string carpeta ="actors";
             public ActorsController(ApplicationDbContext context, IFileStorage fileStorage){
                 this.context = context; 
                 this.FileStorage = fileStorage;
                 
                 
             }           
               
                [HttpPost]
                 public async Task<ActionResult<int>> Post(Actor actor){
                     if(!string.IsNullOrWhiteSpace(actor.Photo)){
                     var actor_photo = Convert.FromBase64String(actor.Photo);
                     actor.Photo = await FileStorage.SaveFile(actor_photo,".jpg", carpeta);
                     }
                context.Add(actor);
                await context.SaveChangesAsync();
                return actor.Id;
            
        }
    }
}