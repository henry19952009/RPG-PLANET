using blazorProyI.Shared.Entity;
using System.Collections.Generic;
using blazorProyI.Client.Services;
using System.Threading.Tasks;
namespace blazorProyI.Client.Services
{
    public interface IServicesActor
    {
        List<Actor> GetActors();
            
             Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
        
    }
}