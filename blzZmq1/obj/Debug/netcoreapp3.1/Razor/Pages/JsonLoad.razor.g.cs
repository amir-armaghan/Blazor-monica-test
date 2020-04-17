#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc0ad3ca17e8d1b95e392729a158355905befb87"
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/jsonload")]
    public partial class JsonLoad : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Load JSON files</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Read Json\'s content files from relative path</h4>\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
                  ReadSimFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "sim_JSON");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "<br>\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
                  ReadSiteFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "site_JSON");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "<br>\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
                  ReadCropFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "crop_JSON");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "fixwidth");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
                     fileTextContents

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\JsonLoad.razor"
       

    string fileTextContents = "Loading";

    // This Component is for test so I didn't create a service and repeated the following methods

    async Task ReadSimFile()
    {
        FileStream inputStream = new FileStream("Data/sim.json", FileMode.Open);

        using (var reader = new System.IO.StreamReader(inputStream))
        {

            fileTextContents = await reader.ReadToEndAsync();
           // object fileTextContents2 = JsonConvert.DeserializeObject(fileTextContents); // if I want to change the json to a .NET object
           
        }
    }
    async Task ReadSiteFile()
    {
        FileStream inputStream = new FileStream("Data/site.json", FileMode.Open);

        using (var reader = new System.IO.StreamReader(inputStream))
        {
            fileTextContents = await reader.ReadToEndAsync();
        }
    }
    async Task ReadCropFile()
    {
        FileStream inputStream = new FileStream("Data/crop.json", FileMode.Open);

        using (var reader = new System.IO.StreamReader(inputStream))
        {
            fileTextContents = await reader.ReadToEndAsync();
        }
    }




    /*string status;

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);

            status = $"Finished loading {file.Size} bytes from {file.Name}";

            var content = new MultipartFormDataContent {
                { new ByteArrayContent(ms.GetBuffer()), "\"upload\"", file.Name }
            };
            await client.PostAsync("upload", content);
        }
    }*/

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591
