#pragma checksum "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7336d852ba755a2c963cca53ce14ce2f120b92ed"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorProyI.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using blazorProyI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using blazorProyI.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using blazorProyI.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/felipe/Vídeos/blazorProyI/Client/_Imports.razor"
using blazorProyI.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class CardMoviesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<h6>Peliculas</h6>\r\n  ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row row-cols-1 row-cols-md-3 g-4");
#nullable restore
#line 5 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
     foreach (var movie in Movies){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12 col-lg-4 mb-3");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card h-100");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 9 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                     movie.MovieImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", "card-img-top");
            __builder.AddAttribute(12, "width", "150");
            __builder.AddAttribute(13, "height", "400");
            __builder.AddAttribute(14, "data-bs-dismiss", "modal");
            __builder.AddAttribute(15, "aria-label", "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n          ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.OpenElement(19, "h4");
            __builder.AddAttribute(20, "class", "card-title");
            __builder.AddContent(21, 
#nullable restore
#line 11 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                    movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "h6");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, 
#nullable restore
#line 12 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                    movie.Score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "h6");
            __builder.AddAttribute(28, "class", "card-title");
            __builder.AddContent(29, 
#nullable restore
#line 13 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                    movie.Premier

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "data-bs-toggle", "modal");
            __builder.AddAttribute(35, "data-bs-target", "#modal_" + (
#nullable restore
#line 15 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                                                                                         movie.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Mas...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal fade");
            __builder.AddAttribute(39, "id", "modal_" + (
#nullable restore
#line 22 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                         movie.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "tabindex", "-1");
            __builder.AddAttribute(41, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(42, "aria-hidden", "False");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-dialog modal-dialog-centered modal-dialog-scrollable");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-content");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-header");
            __builder.OpenElement(49, "h5");
            __builder.AddAttribute(50, "class", "modal-title");
            __builder.AddAttribute(51, "id", "exampleModalLabel");
            __builder.AddContent(52, 
#nullable restore
#line 26 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                                            movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n          ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-body");
            __builder.AddContent(57, 
#nullable restore
#line 29 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
                                   movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"


    } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/CardMoviesComponent.razor"
       
    [Parameter] public List<Movie> Movies { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
