#pragma checksum "/home/felipe/Vídeos/blazorProyI/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ebe559cf5cc8e73c7ae7087505050020c4d1d02"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorProyI.Client.Pages
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
#nullable restore
#line 2 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Index.razor"
using blazorProyI.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<blazorProyI.Client.Pages.Components.CardMoviesComponent>(0);
            __builder.AddAttribute(1, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<blazorProyI.Shared.Entity.Movie>>(
#nullable restore
#line 4 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Index.razor"
                             Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Index.razor"
       
    private List <Movie> Movies;
    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
