#pragma checksum "C:\FemiFriendsApp\server\Pages\MyFriends.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5e833c4e5119fd11bed310f42aee666f8fc05b7"
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
#line 5 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
using FemiFriendsApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/my-friends")]
    public partial class MyFriends : FemiFriendsApp.Pages.MyFriendsComponent
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
                __builder2.AddAttribute(6, "Text", "My Friends");
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
#line 14 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<FemiFriendsApp.Models.ConData.MyFriend>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                   FilterMode.Advanced

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FemiFriendsApp.Models.ConData.MyFriend>>(
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                                                      getMyFriendsResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<FemiFriendsApp.Models.ConData.MyFriend>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<FemiFriendsApp.Models.ConData.MyFriend>(this, 
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                                                                                                                                     Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(27, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(29);
                    __builder3.AddAttribute(30, "Property", "FriendID");
                    __builder3.AddAttribute(31, "Title", "Friend ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(33);
                    __builder3.AddAttribute(34, "Property", "FirstName");
                    __builder3.AddAttribute(35, "Title", "First Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(37);
                    __builder3.AddAttribute(38, "Property", "OtherNames");
                    __builder3.AddAttribute(39, "Title", "Other Names");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(41);
                    __builder3.AddAttribute(42, "Property", "Surname");
                    __builder3.AddAttribute(43, "Title", "Surname");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(45);
                    __builder3.AddAttribute(46, "Property", "GenderID");
                    __builder3.AddAttribute(47, "SortProperty", "Gender.GenderName");
                    __builder3.AddAttribute(48, "FilterProperty", "Gender.GenderName");
                    __builder3.AddAttribute(49, "Title", "Gender");
                    __builder3.AddAttribute(50, "Template", (Microsoft.AspNetCore.Components.RenderFragment<FemiFriendsApp.Models.ConData.MyFriend>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(51, "\n              ");
                        __builder4.AddContent(52, 
#line 28 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                data.Gender?.GenderName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(53, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(55);
                    __builder3.AddAttribute(56, "Property", "DateOfBirth");
                    __builder3.AddAttribute(57, "FormatString", "{0:dd MMMM yyyy}");
                    __builder3.AddAttribute(58, "Title", "Date Of Birth");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(60);
                    __builder3.AddAttribute(61, "Property", "ResidentialAddress");
                    __builder3.AddAttribute(62, "Title", "Residential Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(64);
                    __builder3.AddAttribute(65, "Property", "City");
                    __builder3.AddAttribute(66, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(68);
                    __builder3.AddAttribute(69, "Property", "CountryID");
                    __builder3.AddAttribute(70, "SortProperty", "Country.CountryName");
                    __builder3.AddAttribute(71, "FilterProperty", "Country.CountryName");
                    __builder3.AddAttribute(72, "Title", "Country");
                    __builder3.AddAttribute(73, "Template", (Microsoft.AspNetCore.Components.RenderFragment<FemiFriendsApp.Models.ConData.MyFriend>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(74, "\n              ");
                        __builder4.AddContent(75, 
#line 39 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                data.Country?.CountryName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(76, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(78);
                    __builder3.AddAttribute(79, "Property", "StateID");
                    __builder3.AddAttribute(80, "SortProperty", "State.StateName");
                    __builder3.AddAttribute(81, "FilterProperty", "State.StateName");
                    __builder3.AddAttribute(82, "Title", "State");
                    __builder3.AddAttribute(83, "Template", (Microsoft.AspNetCore.Components.RenderFragment<FemiFriendsApp.Models.ConData.MyFriend>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(84, "\n              ");
                        __builder4.AddContent(85, 
#line 44 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                data.State?.StateName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(86, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(88);
                    __builder3.AddAttribute(89, "Property", "WhatsappNumber");
                    __builder3.AddAttribute(90, "Title", "Whatsapp Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(92);
                    __builder3.AddAttribute(93, "Property", "OtherPhoneNumber");
                    __builder3.AddAttribute(94, "Title", "Other Phone Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(96);
                    __builder3.AddAttribute(97, "Property", "Email");
                    __builder3.AddAttribute(98, "Title", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(100);
                    __builder3.AddAttribute(101, "Property", "Photo");
                    __builder3.AddAttribute(102, "Title", "Photo");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<FemiFriendsApp.Models.ConData.MyFriend>>(104);
                    __builder3.AddAttribute(105, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 55 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                         false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(106, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 55 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                          false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(107, "Width", "70px");
                    __builder3.AddAttribute(108, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 55 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                                                         TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(109, "Template", (Microsoft.AspNetCore.Components.RenderFragment<FemiFriendsApp.Models.ConData.MyFriend>)((femiFriendsAppModelsConDataMyFriend) => (__builder4) => {
                        __builder4.AddMarkupContent(110, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                        __builder4.AddAttribute(112, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 57 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(113, "Icon", "close");
                        __builder4.AddAttribute(114, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 57 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(115, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 57 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, femiFriendsAppModelsConDataMyFriend)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(116, "onclick", 
#line 57 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                                                                                                                                                                                                                   true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(117, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(119, (__value) => {
#line 16 "C:\FemiFriendsApp\server\Pages\MyFriends.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<FemiFriendsApp.Models.ConData.MyFriend>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591