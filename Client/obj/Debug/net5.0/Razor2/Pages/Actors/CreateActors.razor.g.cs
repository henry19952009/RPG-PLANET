#pragma checksum "/home/felipe/Vídeos/blazorProyI/Client/Pages/Actors/CreateActors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8314859864d958095009c4614a5574daa54915c2"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorProyI.Client.Pages.Actors
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
#line 2 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Actors/CreateActors.razor"
using blazorProyI.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/create")]
    public partial class CreateActors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<blazorProyI.Client.Pages.Components.FormActor>(0);
            __builder.AddAttribute(1, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 3 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Actors/CreateActors.razor"
                          Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazorProyI.Shared.Entity.Actor>(
#nullable restore
#line 3 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Actors/CreateActors.razor"
                                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "/home/felipe/Vídeos/blazorProyI/Client/Pages/Actors/CreateActors.razor"
      
    private Actor Actor = new Actor();
    void Create(){
        Console.WriteLine("");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
