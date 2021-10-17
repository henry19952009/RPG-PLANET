using System;
using blazorProyI.Shared.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazorProyI.Client.Services
{
    /* Las interfaces son abstractas, no implementan los métodos */
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T send);
    }
}