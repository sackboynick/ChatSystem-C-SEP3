#pragma checksum "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc8adf99acd83a2418655a520f2c3e7ddeb067f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
using BlazorClient.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrationPage")]
    public partial class RegistrationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>RegistrationPage</h3>\n\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Login</h4>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
                          _user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
                                                OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label>Username</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
                                        _user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _user.Username = __value, _user.Username))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _user.Username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>First name</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
                                        _user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _user.FirstName = __value, _user.FirstName))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _user.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label>Last name</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
                                        _user.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _user.LastName = __value, _user.LastName))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _user.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "<label>Password</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
                                        _user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _user.Password = __value, _user.Password))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _user.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n\n            ");
                __builder2.AddMarkupContent(48, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Register</button></p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/home/c/Desktop/RiderProjects/ChatSystem/BlazorClient/Pages/RegistrationPage.razor"
       

    private User _user;
    
    
    protected override async Task OnInitializedAsync()
    {
        _user = new User();
    }

    private void OnValidSubmit()
    {
        _userService.RegisterUser(_user);
        _navigationManager.NavigateTo("/");
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
