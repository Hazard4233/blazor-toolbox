#pragma checksum "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1deff04412794dd559a3a04a5d251a5009226772"
// <auto-generated/>
#pragma warning disable 1591
namespace Blz.FormBuilder.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1><br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "h3");
                __builder2.AddContent(5, "Welcome, ");
                __builder2.AddContent(6, 
#nullable restore
#line 8 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\Index.razor"
                      context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<h3>You are signed out</h3>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<Blz.FormBuilder.Shared.SurveyPrompt>(12);
            __builder.AddAttribute(13, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\Index.razor"
       
    public string activation_code { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
