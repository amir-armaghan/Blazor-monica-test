#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqProducer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "926a3650d67db08d6143b36d2f675d9f9fe6f12a"
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqProducer.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqProducer.razor"
using Mas.Rpc;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/zmqproducer")]
    public partial class ZmqProducer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Send ENV via ZMQ</h3>\r\n    \r\n    ");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqProducer.razor"
                      CreateMassage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Send static files via ZMQ to ZMQ Server");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "class", "fixwidth");
            __builder.AddContent(7, 
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqProducer.razor"
                         envContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ZmqProducer.razor"
       

   // IFileListEntry file;
    string envContent;
    //public static string sssdds = Services.ZmqProducer.RunProducer();

    async Task CreateMassage() // call ZmqProducer calss
    {
        //var envService = EnvClient.GetMain<Mas.Rpc.Monica.IEnv>();
        //env = await envService.Create("bla", "bli", "blo");

        string envContent = Services.ZmqProducer.RunProducer();
        //RunProducer();



        //push msg here...
        using (var producer = new PushSocket())
        {
            producer.Connect(AppData.ServerPushAddress + ":" + AppData.ServerPushPort);
            producer.SendFrame(envContent);
            System.Threading.Thread.Sleep(2000);
            producer.Disconnect(AppData.ServerPushAddress + ":" + AppData.ServerPushPort);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ZmqProducer RunProducer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591