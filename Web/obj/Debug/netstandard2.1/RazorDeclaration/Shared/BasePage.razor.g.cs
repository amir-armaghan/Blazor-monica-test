#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\Web\Shared\BasePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38a34cd9fa53fa511a44a7809de2907b284f9a5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using NetMQ.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\Web\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
    public partial class BasePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\Web\Shared\BasePage.razor"
      

    #region Notifications

    public async Task ShowSuccessMessageAsync(string title, string message = "")
    {
        var notify = new NotificationMessage()
        {
            Severity = NotificationSeverity.Success,
            Summary = title,
            Detail = message,
            Duration = 4000
        };

        await ShowNotification(notify);
    }

    public async Task ShowErrorMessageAsync(string title, string message = "")
    {
        var notify = new NotificationMessage()
        {
            Severity = NotificationSeverity.Error,
            Summary = title,
            Detail = message,
            Duration = 4000
        };

        await ShowNotification(notify);
    }

    public async Task ShowInfoMessageAsync(string title, string message = "")
    {
        var notify = new NotificationMessage()
        {
            Severity = NotificationSeverity.Info,
            Summary = title,
            Detail = message,
            Duration = 4000
        };

        await ShowNotification(notify);
    }

    public async Task ShowWarningMessageAsync(string title, string message = "")
    {
        var notify = new NotificationMessage()
        {
            Severity = NotificationSeverity.Warning,
            Summary = title,
            Detail = message,
            Duration = 4000
        };

        await ShowNotification(notify);
    }

    async Task ShowNotification(NotificationMessage message)
    {
        notificationService.Notify(message);

        await InvokeAsync(() => { StateHasChanged(); });
    }
    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Radzen.NotificationService notificationService { get; set; }
    }
}
#pragma warning restore 1591
