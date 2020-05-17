#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqConsumer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67ca60f49317ded1c8d51f320a8eee654029ba71"
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqConsumer.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqConsumer.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqConsumer.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zmqconsumer")]
    public partial class ZmqConsumer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqConsumer.razor"
       

    Boolean gotAnswer = false;
    public string answer { get; set; } = "No Answer yet";
    private string CsvLink { get; set; } = "No Link yet";

    async Task GetMassage() // call ZmqProducer calss
    {

        //RunConsumer();

        using (var consumer = new PullSocket())
        //using (var producer = new RequestSocket())
        {
            //consumer.Connect("tcp://localhost:7777");
            consumer.Connect(AppData.ServerPullAddress + ":" + AppData.ServerPullPort);
            answer = consumer.ReceiveFrameString();

            System.Threading.Thread.Sleep(2000);
            gotAnswer = true;
            consumer.Disconnect(AppData.ServerPullAddress + ":" + AppData.ServerPullPort);

            // create path
            string filePath = "wwwroot/export/" + DateTime.Now.ToString("yyyyMMdd_hhmmss");

            //write the answer into a file
            string jsonFile = (filePath + ".json");
            if (!File.Exists(jsonFile))
                File.WriteAllText(jsonFile, answer);

            // call runConsumer Method(). get ths csv path, remove wwwroot and use the link in razor section
            CsvLink = Services.ZmqConsumer.RunConsumer(answer, filePath);
            CsvLink = CsvLink.Substring(CsvLink.IndexOf("/"));
            System.Threading.Thread.Sleep(1000);
            NavigationManager.NavigateTo("/monicaCharts/monicaChart");

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ZmqConsumer RunConsumer { get; set; }
    }
}
#pragma warning restore 1591
