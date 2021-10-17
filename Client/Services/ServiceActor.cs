using System;
using System.Collections.Generic;
using blazorProyI.Client.Services;
using blazorProyI.Shared.Entity;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace blazorProyI.Client.Services
{
    public class ServiceActor:IServicesActor
    {
        private readonly HttpClient httpClient;
            public ServiceActor(HttpClient httpClient) {
                this.httpClient = httpClient;
                }
               public async Task<HttpResponseWrapper<object>> Post<T>(string url, T send){
                   var sendJSON = JsonSerializer.Serialize(send);
                   var sendContent = new StringContent(sendJSON, Encoding.UTF8,"application/json");
                   var responseHttp = await httpClient.PostAsync(url, sendContent);
                   return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode,responseHttp);
               
        }
        public List <Actor> GetActors(){
            return new List<Actor>{
                new Actor(){Id =1,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =2,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =3,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =4,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =5,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =6,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =7,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =8,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =9,Name = "Actor 1" ,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""},
                new Actor(){Id =10,Name = "Actor 1",BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = "",Biography="Biografía...", Photo="/Images/Actors/actor1.jpg",Character = ""}
                
            };
        }
    }
}
