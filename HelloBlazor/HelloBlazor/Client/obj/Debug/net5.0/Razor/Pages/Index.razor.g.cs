#pragma checksum "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1962c0ed484cc8b6e16444de69dfb622137b1bee"
// <auto-generated/>
#pragma warning disable 1591
namespace HelloBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using HelloBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using HelloBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\_Imports.razor"
using HelloBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pizza-cards");
#nullable restore
#line 5 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
         if (Specials != null)
        {
            foreach (var Special in Specials)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "style", "background-image:url(\'" + (
#nullable restore
#line 9 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
                                                  Special.ImageUrl

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "pizza-info");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "title");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
                                             Special.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.AddContent(12, 
#nullable restore
#line 12 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
                         Special.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "price");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
                             Special.GetFormattedBasePrice()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\WM\source\repos\HelloBlazor\HelloBlazor\Client\Pages\Index.razor"
      
    List<PizzaSpecial> Specials;
    protected async override Task OnInitializedAsync()
    {
        Specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
