#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1692c300a216c04113a267edcb5d8c629ae830aa"
// <auto-generated/>
#pragma warning disable 1591
namespace blzZmq1.Pages.UploadData
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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/uploadData")]
    public partial class UploadData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Upload data</h1>\r\n");
            __builder.AddMarkupContent(1, "<h3>Select your files and upload to the server</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "drag-drop-zone");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(5);
            __builder.AddAttribute(6, "multiple", true);
            __builder.AddAttribute(7, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 19 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
                                  ViewFile

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddContent(9, 
#nullable restore
#line 20 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
     status

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
#nullable restore
#line 23 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
 if (_files != null)
{
    foreach (var file in _files)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "file-row");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "h2");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
                 file.File.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddContent(20, " ");
            __builder.AddMarkupContent(21, "<b>size</b> ");
            __builder.AddContent(22, 
#nullable restore
#line 29 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
                               file.File.Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 30 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
                                                                           file.IsUploaded

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
                                                                                                      (() => RemoveFile(file))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 32 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<hr>\r\n");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
                                          HandleFiles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Send to server");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 36 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
 if (IsDataSent)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.AddMarkupContent(39, "<span>Data sent</span>\r\n");
#nullable restore
#line 39 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
 if (!string.IsNullOrWhiteSpace(SendToServerStatus))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.AddMarkupContent(41, "<div class=\"alert alert-success\" role=\"alert\">\r\n        Data has been sent to server.\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
       
    const string DefaultStatus = "Drop a text file here to view it, or click to choose a file";
    const int MaxFileSize = 5 * 1024 * 1024; // 5MB
    string status = DefaultStatus;

    private List<UploadedFilesModel> _files = new List<UploadedFilesModel>();
    private bool IsDataSent = false;
    private string SendToServerStatus = string.Empty;

    //string githubPath;
    // void GetRepoContnet()
    //{
       // GithubService.SetRepoInfo("https://github.com/armaghan-work/armaghan-monica-params");
       // //bool result = GithubService.IsExistPathAsync(githubPath).Result;
       // GithubService.CreateFile();
    //}

    async Task ViewFile(IFileListEntry[] files)
    {
        SendToServerStatus = string.Empty;

        if (files.Length == 0)
        {
            return;
        }
        else
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Size > MaxFileSize)
                {
                    status = $"That's too big. Max size: {MaxFileSize} bytes.";
                    return;
                }
            }

            status = "Loading...";

            for (int i = 0; i < files.Length; i++)
            {
                if (!_files.Any(file => file.File.Name == files[i].Name && file.File.Size == files[i].Size))
                    _files.Add(new UploadedFilesModel() { File = files[i] });
            }

            status = DefaultStatus;
        }
    }

    private void RemoveFile(UploadedFilesModel file)
    {
        _files.Remove(file);
    }

    private async Task HandleFiles()
    {
        var filePathes = new List<string>();
        FileUpload.DeleteExistingFiles();

        foreach (var file in _files)
        {
            var filePath = await FileUpload.UploadAsync(file.File);
            filePathes.Add(filePath);
        }

        var producer = new ZmqProducer();
        var result = await producer.RunProducerAsync(filePathes);

        IsDataSent = MonicaZmqService.Send(result);

        if (IsDataSent)
        {
            _files = new List<UploadedFilesModel>();
        }
    }

    class UploadedFilesModel
    {
        public UploadedFilesModel()
        {
            IsUploaded = false;
        }

        public IFileListEntry File { get; set; }

        public bool IsUploaded { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blzZmq1.Services.Github.IGithubService GithubService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonicaZmqService MonicaZmqService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
    }
}
#pragma warning restore 1591