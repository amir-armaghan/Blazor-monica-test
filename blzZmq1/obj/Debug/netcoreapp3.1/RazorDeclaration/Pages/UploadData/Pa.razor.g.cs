#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Pa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ee7b707988dd05192a783a26511424c4cd5a7f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Pa.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Pa.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Pa.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/uploadData")]
    public partial class Pa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Pa.razor"
       
    const string DefaultStatus = "Drop a text file here to view it, or click to choose a file";
    const int MaxFileSize = 5 * 1024 * 1024; // 5MB
    string status = DefaultStatus;

    private List<UploadedFilesModel> _files = new List<UploadedFilesModel>();
    private bool IsDataSent = false;
    private string SendToServerStatus = string.Empty;

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonicaZmqService MonicaZmqService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
    }
}
#pragma warning restore 1591
