#pragma checksum "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c8acfb66dfc2e7978c54a13e562320336070af"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlannerApp.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\Pages\Auth\Login.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "c:\users\pk1006\source\repos\plannerapp\PlannerApp.Client\Pages\Auth\Login.razor"
       
    LoginRequest model = new LoginRequest();
    bool isBusy = false;
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;

    public async Task LoginUser()
    {
        isBusy = true;

        var result = await authService.LoginAsync(model);
        if (result.IsSuccess)
        {
            message = "Welcome to Planner App";
            messageType = Models.AlertMessageType.Success;

            var userInfo = new Models.LocalUserInfo()
            {
                AccessToken = result.Message,
                Email = result.UserInfo["Email"],
                FirstName = result.UserInfo["FirstName"],
                LastName = result.UserInfo["LastName"],
                Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier]
            };
            await storageService.SetItemAsync("user", userInfo);
        }
        else
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Error;
        }
        isBusy = false;
    }

    void GotoRegister()
    {
        navigationManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService storageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
