#pragma checksum "C:\FemiFriendsApp\server\Pages\Genders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d115aa73c0e80b7d3658b706ea0b128fd66f6cab"
// <auto-generated/>
#pragma warning disable 1591
namespace FemiFriendsApp.Pages
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
#line 5 "C:\FemiFriendsApp\server\Pages\Genders.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\FemiFriendsApp\server\Pages\Genders.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\FemiFriendsApp\server\Pages\Genders.razor"
using FemiFriendsApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/genders")]
    public partial class Genders : FemiFriendsApp.Pages.GendersComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Genders");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 14 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<FemiFriendsApp.Models.ConData.Gender>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FemiFriendsApp.Models.ConData.Gender>>(
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                                                      getGendersResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<FemiFriendsApp.Models.ConData.Gender>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<FemiFriendsApp.Models.ConData.Gender>(this, 
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                                                                                                                                 Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(27, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.Gender>>(29);
                    __builder3.AddAttribute(30, "Property", "GenderID");
                    __builder3.AddAttribute(31, "Title", "Gender ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.Gender>>(33);
                    __builder3.AddAttribute(34, "Property", "GenderName");
                    __builder3.AddAttribute(35, "Title", "Gender Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.Gender>>(37);
                    __builder3.AddAttribute(38, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(39, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(40, "Width", "70px");
                    __builder3.AddAttribute(41, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 22 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment<FemiFriendsApp.Models.ConData.Gender>)((femiFriendsAppModelsConDataGender) => (__builder4) => {
                        __builder4.AddMarkupContent(43, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(44);
                        __builder4.AddAttribute(45, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 24 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(46, "Icon", "close");
                        __builder4.AddAttribute(47, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 24 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(48, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 24 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, femiFriendsAppModelsConDataGender)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(49, "onclick", 
#line 24 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                                                                                                                                                                                                                 true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(52, (__value) => {
#line 16 "C:\FemiFriendsApp\server\Pages\Genders.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<FemiFriendsApp.Models.ConData.Gender>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
