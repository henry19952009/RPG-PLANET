// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Components/MovieComponent.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    private string urlMovie = string.Empty;
    protected override void OnInitialized()
    {
        urlMovie = $"movie/";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
