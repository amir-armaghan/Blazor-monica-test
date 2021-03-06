#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffffe56de678100d253dd379d9d00dbef2252f99"
// <auto-generated/>
#pragma warning disable 1591
namespace blzZmq1.Pages
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
using Core.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
using blzZmq1.Services.Github;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting")]
    public partial class Setting : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Setting</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label for=\"basic-url\">Your ZeroMQ server Address</label>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group mb-3");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">Server Push Address:</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(10, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                                                UpdateLocalStorageSettingsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                    UserSetting.ServerPushAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserSetting.ServerPushAddress = __value, UserSetting.ServerPushAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "input-group mb-3");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.AddMarkupContent(18, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">Server Push Port:</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(22, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                                 UpdateLocalStorageSettingsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                        UserSetting.ServerPushPort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserSetting.ServerPushPort = __value, UserSetting.ServerPushPort));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "input-group mb-3");
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.AddMarkupContent(30, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">Server Pull Address:</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(35, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                                                UpdateLocalStorageSettingsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                    UserSetting.ServerPullAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserSetting.ServerPullAddress = __value, UserSetting.ServerPullAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-group mb-3");
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.AddMarkupContent(43, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">Server Pull Port:</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "number");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(48, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                                              UpdateLocalStorageSettingsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                     UserSetting.ServerPullPort

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserSetting.ServerPullPort = __value, UserSetting.ServerPullPort, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.AddMarkupContent(53, "<p> </p>\r\n");
            __builder.AddMarkupContent(54, "<label for=\"basic-url\">Your gitHub authentication information</label>\r\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "input-group mb-3");
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.AddMarkupContent(58, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">User Name:</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "disabled", true);
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(64, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                                                     UpdateLocalStorageSettingsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                            UserSetting.GithubUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserSetting.GithubUserName = __value, UserSetting.GithubUserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "input-group mb-3");
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.AddMarkupContent(72, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">Password:</span>\r\n    </div>\r\n    ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "disabled", true);
            __builder.AddAttribute(75, "type", "password");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(78, "value", 
#nullable restore
#line 47 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                 UserSetting.GithubPassword

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "input-group mb-3");
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.AddMarkupContent(84, "<div class=\"input-group-prepend\">\r\n        <span class=\"input-group-text\" id=\"basic-addon3\">github Path Validator:</span>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
     if (UserSetting.MonicaPathOnGitIsValid == false) //show proper icon when is Not valid
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "        ");
            __builder.AddMarkupContent(86, @"<div class=""input-group-prepend tooltip2"">
            <span class=""input-group-text tooltip2"" id=""basic-addon3"">&#9888;</span>
            <span class=""tooltiptext"">
                <strong>Only After logging-in:</strong> <br>
                Please enter your full github repository Address which contains ""monica parameters"" in its root <br>
                Do not add Slash (/) at the the end of this address. <br>
                After entering the path, click on ""Validate the path"" button.
            </span>
        </div>
");
#nullable restore
#line 64 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
    }
    else // when path is valid
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "        ");
            __builder.AddMarkupContent(88, "<div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\" id=\"basic-addon3\">&#10004;</span>\r\n        </div>\r\n");
#nullable restore
#line 70 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "    ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "text");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "aria-describedby", "basic-addon3");
            __builder.AddAttribute(94, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                                           PathChangedAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                   somePath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => somePath = __value, somePath));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "input-group-prepend");
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "class", "btn btn-info btn-sm rounded-right");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                                                                                  GithubPathValidation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Validate the path");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
       

    Boolean value;

    private string somePath = string.Empty;

    void Change(bool value)
    {
        // do something
    }



    //somePath = UserSetting.MonicaParametersPathOnGithub;



    async Task GithubPathValidation()
    {
        if (!string.IsNullOrWhiteSpace(somePath))
        {

            string repoPath = GithubService.GetRepoResultPath(somePath);
            UserSetting.MonicaPathOnGitIsValid = GithubService.PathValidator(UserSetting.MonicaResultsPathOnGithub, UserSetting.GithubUserName, UserSetting.GithubPassword, repoPath);
            await SaveUserSettingsInLocalStorageAsync();
        }
    }

    async Task PathChangedAsync()
    {
        UserSetting.MonicaPathOnGitIsValid = false;
        await SaveUserSettingsInLocalStorageAsync();
    }

    async Task UpdateLocalStorageSettingsAsync()
    {
        await SaveUserSettingsInLocalStorageAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGithubService GithubService { get; set; }
    }
}
#pragma warning restore 1591
