using System.Net;
using System.Text;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Globalization;
using System;
using blazorProyI.Shared.Entity;
using System.Collections.Generic;
using blazorProyI.Client.Services;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace blazorProyI.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        private readonly HttpClient httpClient;
            public ServiceMovie(HttpClient httpClient) {
                this.httpClient = httpClient;
                }
               public async Task<HttpResponseWrapper<object>> Post<T>(string url, T send){
                   var sendJSON = JsonSerializer.Serialize(send);
                   var sendContent = new StringContent(sendJSON, Encoding.UTF8,"application/json");
                   var responseHttp = await httpClient.PostAsync(url, sendContent);
                   return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode,responseHttp);
               
        }
         public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){Id=0,Name="Free guy",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/xmbU4JTUm8rsdtn7Y3Fcm30GpeT.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=1,Name="venom",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rjkmN1dniUHVYAtwuV3Tji7FsDO.jpg" ,Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=2,Name="El Ultimo Guerrero",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/5VJSIAhSn4qUsg5nOj4MhQhF5wQ.jpg" ,Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=3,Name="Creazy Fist",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/jVAEVDNdUPRKJ7hJ4zt6lGcLATD.jpg" ,Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=4,Name="Shang Shi",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1BIoJGKbXjdFDAqUEiA2VHqkK1Z.jpg" ,Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=5,Name="rapidos y furiosos",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg" ,Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=6,Name="Movie 8",MovieImage="/Images/Movies/Movie8.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=7,Name="Movie 9",MovieImage="/Images/Movies/Movie9.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=8,Name="Movie 10",MovieImage="/Images/Movies/Movie10.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Id=9,Name="Movie 11",MovieImage="/Images/Movies/Movie11.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)} 
        };
    }
}
}