#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b99c74d54e75a76227bdcef8d48d4c757b8b36"
// <auto-generated/>
#pragma warning disable 1591
namespace blzZmq1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting")]
    public partial class Setting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Setting</h3>\r\n\r\nServer Push Address:\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                          AppData.ServerPushAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppData.ServerPushAddress = __value, AppData.ServerPushAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\nServer Push Port:\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "number");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                            AppData.ServerPushPort

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppData.ServerPushPort = __value, AppData.ServerPushPort, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<br>\r\nServer Pull Address:\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                          AppData.ServerPullAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppData.ServerPullAddress = __value, AppData.ServerPullAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<br>\r\nServer Pull Port:\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "number");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
                            AppData.ServerPullPort

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppData.ServerPullPort = __value, AppData.ServerPullPort, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n<p></p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
       





    // // it is supposed later makeing this code to read settings from an ini file.
    /*private const String ConfigFileName = "Config.ini";


    public Dictionary<string, string> readConfigFile()
    {
        var lines = File.ReadAllLines(ConfigFileName);
        Dictionary<string, string> dict = new Dictionary<string, string>();
        foreach (string s in lines)
        {
            string[] split = s.Split("=");
            dict.Add(split[0], split[1]);
        }

        return dict;
    }*/

    // //string s = string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray());


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData AppData { get; set; }
    }
}
#pragma warning restore 1591
