#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9bed731e52c88f29c1aac9eb15fb61a3d56f38b"
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fileInput")]
    public partial class FileInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FileInput</h3>\r\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(1);
            __builder.AddAttribute(2, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
                     HandleFileSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
 if (file != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Name: ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
              file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Size in bytes: ");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
                       file.Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "File type: ");
            __builder.AddContent(15, 
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
                   file.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Last modified date: ");
            __builder.AddContent(19, 
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
                            file.LastModified.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Number of lines read: ");
            __builder.AddContent(23, 
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
                              numLines

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
                      CountLines

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Send via ZMQ and show the content");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.AddContent(29, "    ");
            __builder.OpenElement(30, "pre");
            __builder.AddContent(31, 
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
          fileTextContents

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\FileInput.razor"
       
    int numLines;
    IFileListEntry file;
    string fileTextContents;
    async Task HandleFileSelected(IFileListEntry[] files)
    {
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
            producer.Connect("tcp://localhost:6666");
            producer.SendFrame(fileTextContents);
            //producer.SendFrame("Hello push socket");
            //var message = producer.ReceiveFrameString();
            //string text1 = "push message from blazor";
            // producer.SendFrame(text1);
            //var message = producer.ReceiveFrameString();
            System.Threading.Thread.Sleep(5000);  // it needs some time to send the request so made a delay

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




    /* using (var client = new RequestSocket())
     {
         client.Connect("tcp://localhost:6666");
         for (int i = 0; i < 10; i++)
         {
             //Console.WriteLine("Sending Hello");
             client.SendFrame("Hello");
             var message = client.ReceiveFrameString();
             Console.WriteLine("Received {0}", message);
         }
     }*/



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591
