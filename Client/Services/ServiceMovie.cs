using System;
using blazorProyI.Shared.Entity;
using System.Collections.Generic;
using blazorProyI.Client.Services;

namespace blazorProyI.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
         public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){MovieName="Free guy",MovieImage="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/xmbU4JTUm8rsdtn7Y3Fcm30GpeT.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 3",MovieImage="/Images/Movies/Movie3.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="El juego del calamar",MovieImage="/Images/Movies/Movie4.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 5",MovieImage="/Images/Movies/Movie5.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Intrusion",MovieImage="/Images/Movies/Movie6.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 7",MovieImage="/Images/Movies/Movie7.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 8",MovieImage="/Images/Movies/Movie8.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 9",MovieImage="/Images/Movies/Movie9.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 10",MovieImage="/Images/Movies/Movie10.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 11",MovieImage="/Images/Movies/Movie11.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)} 
        };
    }
}
}