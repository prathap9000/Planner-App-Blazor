#pragma checksum "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77cc3762eabace8861da5f3a02087ba616c54b77"
// <auto-generated/>
#pragma warning disable 1591
namespace PlannerApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
    public partial class AlertMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor"
 if (!string.IsNullOrWhiteSpace(Message))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert" + " " + (
#nullable restore
#line 3 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor"
                       alertClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor"
                                    Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor"
                                                            HideMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 4 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\pk1006\source\repos\PlannerApp\PlannerApp.Client\Shared\AlertMessage.razor"
       
    [Parameter]
    public string Message { get; set; }

    private Models.AlertMessageType messageType;

    [Parameter]
    public Models.AlertMessageType MessageType
    {
        get => messageType;
        set
        {
            messageType = value;
            switch (messageType)
            {
                case Models.AlertMessageType.Error:
                    alertClass = "alert-danger";
                    break;
                case Models.AlertMessageType.Warning:
                    alertClass = "alert-warning";
                    break;
                case Models.AlertMessageType.Success:
                    alertClass = "alert-success";
                    break;
                default:
                    break;
            }
        }
    }

    string alertClass = "alert-info";
    void HideMessage()
    {
        Message = string.Empty;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
