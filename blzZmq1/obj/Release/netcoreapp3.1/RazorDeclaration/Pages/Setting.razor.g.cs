#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35750cb7666b4e45b30adc83183c00c4cefdd08c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Setting.razor"
       




    // // it is supposed later makeing this code to read settings from an ini file. Not sure if it is a good idea
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