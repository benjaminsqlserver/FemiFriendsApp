#pragma checksum "C:\FemiFriendsApp\server\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "536293c0b1171369f029f78d501941f092d703e7"
// <auto-generated/>
#pragma warning disable 1591
namespace FemiFriendsApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\FemiFriendsApp\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\FemiFriendsApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\FemiFriendsApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\FemiFriendsApp\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\FemiFriendsApp\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\FemiFriendsApp\server\_Imports.razor"
using FemiFriendsApp.Shared;

#line default
#line hidden
#line 3 "C:\FemiFriendsApp\server\Shared\LoginLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\FemiFriendsApp\server\Shared\LoginLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\FemiFriendsApp\server\Shared\LoginLayout.razor"
using FemiFriendsApp.Models.ConData;

#line default
#line hidden
    public partial class LoginLayout : FemiFriendsApp.Layouts.LoginLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(8);
            __builder.AddAttribute(9, "style", "margin-left: 0px");
            __builder.AddAttribute(10, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 11 "C:\FemiFriendsApp\server\Shared\LoginLayout.razor"
                                                            true

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row justify-content-center");
                __builder2.AddMarkupContent(15, "\n      ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "justify-content-center col-xl-5 col-md-7");
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(19);
                __builder2.AddAttribute(20, "style", "margin-top: 8rem");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenContentContainer>(23);
                    __builder3.AddAttribute(24, "Name", "main");
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\n            ");
                        __builder4.AddContent(27, 
#line 18 "C:\FemiFriendsApp\server\Shared\LoginLayout.razor"
             Body

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(28, "\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#line 11 "C:\FemiFriendsApp\server\Shared\LoginLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
