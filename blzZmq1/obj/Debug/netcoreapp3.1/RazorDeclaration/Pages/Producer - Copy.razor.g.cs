#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Producer - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0767ae5cea3e5d86eab49368581372b2dbccca0f"
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Producer - Copy.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Producer - Copy.razor"
using Capnp.Rpc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Producer - Copy.razor"
using Mas.Rpc;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/producer")]
    public partial class Producer___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\Producer - Copy.razor"
       
    //private Capnp.Rpc.TcpRpcClient EnvClient;   //capnp by Michael
    //private String env = "nothing"; //capnp by Michael
    int numLines;
    IFileListEntry file;
    string fileTextContents;
    async Task HandleFileSelected(IFileListEntry[] files)
    {
        /*if (EnvClient == null)  //capnp by Michael
        {
            EnvClient = new TcpRpcClient("localhost", 9999);
            await Task.WhenAll(EnvClient.WhenConnected);
        }

        if (EnvClient.State == ConnectionState.Active)  //capnp by Michael
        {
            var envService = EnvClient.GetMain<Mas.Rpc.Monica.IEnv>();

            env = await envService.Create("bla", "bli", "blo");
        }*/

        file = files.FirstOrDefault();

        // the upload process: // if don't use it, the file is on the client memory. That is why we use Async methods.
        using (var reader = new StreamReader(file.Data))
        {
            fileTextContents = await reader.ReadToEndAsync();
        }

        //push msg here...

        if (file != null)
        {
            await fileUpload.UploadAsync(file);
        }
        using (var producer = new PushSocket())
        //using (var producer = new RequestSocket())
        {
            // producer.Connect("tcp://localhost:6666");
            producer.Connect(AppData.ServerPushAddress+":"+AppData.ServerPushPort);
            producer.SendFrame(fileTextContents);
            //string text1 = "push message from blazor";
            // producer.SendFrame(text1);
            //var message = producer.ReceiveFrameString();
            System.Threading.Thread.Sleep(2000);  // it needs some time to send the request so made a delay
            producer.Disconnect(AppData.ServerPushAddress + ":" + AppData.ServerPushPort);

        }

    }
    async Task CountLines() // read number of lines
    {
        numLines = 0;
        using (var reader = new System.IO.StreamReader(file.Data))
        {
            while (await reader.ReadLineAsync() != null)
            {
                numLines++;
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591
