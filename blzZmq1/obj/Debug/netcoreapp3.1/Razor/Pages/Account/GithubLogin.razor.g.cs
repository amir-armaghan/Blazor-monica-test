#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce179461c2f5efc3665cde21e86a4e0385cc0f2"
// <auto-generated/>
#pragma warning disable 1591
namespace blzZmq1.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using blzZmq1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using blzZmq1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using NetMQ.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
using Application.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
using blzZmq1.Services.Github;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
using Core.Share;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/GithubLogin")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/GithubLogin/{loginFailed}")]
    public partial class GithubLogin : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Login to Github</h1>\r\n<br>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
 if(isFailed)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p style=\"color:red\">Login failed !</p>\r\n");
#nullable restore
#line 19 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
}


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
                                          RedirectToGithub

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n<hr>\r\n");
            __builder.AddMarkupContent(8, "<div class=\"m-4\">\r\n    <div class=\"alert alert-warning\" role=\"alert\">\r\n        For optimal use, please read the <a href=\"/help\">Help</a> page first.\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Account\GithubLogin.razor"
      

    Boolean result;
    Boolean firstRun = true;
    bool isFailed = false;

    [Parameter]
    public string LoginFailed { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrWhiteSpace(LoginFailed))
            isFailed = bool.Parse(LoginFailed);
    }

    void RedirectToGithub()
    {
        firstRun = false;
        StateHasChanged();

        var githubUri = GithubService.OAuthLogin();
        NavigationManager.NavigateTo(githubUri.AbsoluteUri);
    }

    async Task Logout()
    {
        UserSetting.GithubLoggedIn = false;
        // to renew the LocalStorage after logout
        UserSetting = new UserSetting();
        await SaveUserSettingsInLocalStorageAsync();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGithubService GithubService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591