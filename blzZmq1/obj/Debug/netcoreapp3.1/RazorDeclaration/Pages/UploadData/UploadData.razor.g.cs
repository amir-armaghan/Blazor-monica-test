#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c12be0d2497a5796016ffeaecaeb3b8de38c86a"
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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using Core.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
using Core.Share.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/uploadData")]
    public partial class UploadData : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 213 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
       
    const string DefaultStatus = "Drop your Sim, Site, Crop and Climate file(s) or just click here to choose you file(s)";
    const int MaxFileSize = 6 * 1024 * 1024; // 6MB
    string status = DefaultStatus;

    private List<UploadedFilesModel> _files = new List<UploadedFilesModel>();
    private bool IsDataSent = false;
    private string SendToServerStatus = string.Empty;
    private string BgColor = string.Empty;
    bool isDataSending = false;
    bool isExportDone = false;
    string jsonDownloadPath = string.Empty;
    string csvDownloadPath = string.Empty;

    bool sim = false;
    bool crop = false;
    bool site = false;
    bool climate = false;

    private string simValue = string.Empty;



    private MonicaParametersBasePathTypeEnum _basePathType = MonicaParametersBasePathTypeEnum.LocalServer;
    private MonicaExportResultType _exportResultType = MonicaExportResultType.DowloadLink;


    [Parameter]
    public string jsonFullDownloadPath { get; set; } = string.Empty;
    [Parameter]
    public string csvFullDownloadPath { get; set; } = string.Empty;


    protected override async Task OnInitializedAsync()
    {
        UserSettingsUpdated += OnAfterUserSettingsUpdatedAsync;
    }

    void OnAfterUserSettingsUpdatedAsync(object sender, EventArgs e)
    {
        StateHasChanged();
    }

    private async Task CopyTextToClipboard(string shareLink)
    {
        await JSRuntime.InvokeVoidAsync("clipboardCopy.copyText", shareLink);
    }


    async Task ViewFile(IFileListEntry[] files)
    {


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
                    status = $"That's too big. Max size: {MaxFileSize/1024/1024} MB";
                    return;
                }
            }

            status = "Loading...";

            for (int i = 0; i < files.Length; i++)
            {
                if (!_files.Any(file => file.File.Name == files[i].Name && file.File.Size == files[i].Size))
                    _files.Add(new UploadedFilesModel() { File = files[i] });
                // add a switch case and check if it is Sim change sim to true and etc,
                // use these values in dialog and present if the file is default one or is uploaded
                if (files[i].Name.Contains("sim"))
                {
                    sim = true;
                }
                else if (files[i].Name.Contains("crop"))
                {
                    crop = true;
                }
                else if (files[i].Name.Contains("site"))
                {
                    site = true;
                }
                else if (files[i].Name.Contains("climate"))
                {
                    climate = true;
                }

            }

            status = DefaultStatus;
        }
    }

    private void RemoveFile(UploadedFilesModel file)
    {
        // switch case - first check the name, if its Sim change its value to false then remove it
        if (file.File.Name.Contains("sim"))
        {
            sim = false;
        }
        else if (file.File.Name.Contains("crop"))
        {
            crop = false;
        }
        else if (file.File.Name.Contains("site"))
        {
            site = false;
        }
        else if (file.File.Name.Contains("climate"))
        {
            climate = false;
        }

        _files.Remove(file);
    }

    private async Task HandleFiles()
    {
        showModal = false; // hide the modal
        isDataSending = true;

        await ResultStatusAsync("Uploading files", 1);

        var filePathes = new List<string>();
        FileUpload.DeleteExistingFiles();

        foreach (var file in _files)
        {
            var filePath = await FileUpload.UploadAsync(file.File);
            filePathes.Add(filePath);
        }

        await ResultStatusAsync("Creating Monica request file", 2);

        var result = await ZmqProducer.RunProducerAsync(filePathes, UserSetting, _basePathType);

        await ResultStatusAsync("Sending the request to Monica ZMQ", 3);
        //SendToServerStatus += $"Sending Monica request file [{DateTime.Now.ToString()}]... " + Environment.NewLine;
        //BgColor = "colorg3";
        //StateHasChanged();

        IsDataSent = MonicaZmqService.Send(result, UserSetting.ServerPushAddress, UserSetting.ServerPushPort);

        if (IsDataSent)
        {
            _files = new List<UploadedFilesModel>();
            await ExportResultAsync();
        }
        else
        {

        }
    }

    async Task ResultStatusAsync(string SendingStatus, int ColorNo)
    {
        SendToServerStatus += SendingStatus + ": " + DateTime.Now.ToLongTimeString() + " ... " + Environment.NewLine;
        switch (ColorNo)
        {
            case 1:
                BgColor = "colorg1";
                break;
            case 2:
                BgColor = "colorg2";
                break;
            case 3:
                BgColor = "colorg3";
                break;
            case 4:
                BgColor = "colorg4";
                break;
            case 5:
                BgColor = "colorg5";
                break;
        }
        StateHasChanged();
    }

    async Task ExportResultAsync() // call ZmqProducer calss
    {
        await ResultStatusAsync("Reciving the result from Monica ZMQ", 4);

        await Task.Delay(2000);

        using (var consumer = new PullSocket())
        {
            consumer.Connect(UserSetting.ServerPullAddress + ":" + UserSetting.ServerPullPort);
            string answer = consumer.ReceiveFrameString();

            await Task.Delay(2000);
            consumer.Disconnect(UserSetting.ServerPullAddress + ":" + UserSetting.ServerPullPort);

            string csvContent = ZmqConsumer.RunConsumer(answer);

            // create path
            string exportPath = "wwwroot/export/";

            foreach (var file in Directory.GetFiles(exportPath))
            {
                if (File.GetCreationTime(file) > DateTime.Now.AddDays(-7))
                    continue;
                //File.Delete(file);
            }

            if (_exportResultType == MonicaExportResultType.DowloadLink)
            {
                //get the base URI Address and remove / from its end
                string baseUriAddress = new Uri(NavigationManager.BaseUri).ToString().TrimEnd('/');

                string fileName = Guid.NewGuid().ToString();
                jsonDownloadPath = Path.Combine(exportPath, fileName + ".json");

                File.WriteAllText(jsonDownloadPath, answer);
                jsonDownloadPath = Path.Combine(HostEnvironment.WebRootPath, jsonDownloadPath);
                jsonDownloadPath = jsonDownloadPath.Substring(jsonDownloadPath.IndexOf("/"));
                jsonFullDownloadPath = baseUriAddress + jsonDownloadPath;

                //fileName = Guid.NewGuid().ToString();  // commented to use the old GUID for csv
                csvDownloadPath = Path.Combine(exportPath, fileName + ".csv");
                File.WriteAllText(csvDownloadPath, csvContent);
                csvDownloadPath = csvDownloadPath.Substring(csvDownloadPath.IndexOf("/"));
                csvFullDownloadPath = baseUriAddress + csvDownloadPath;
            }
            else if (_exportResultType == MonicaExportResultType.Github)
            {
                await ResultStatusAsync("Writing the result to github", 5);

                string fileName = "MonicaResult_" + DateTime.Now.ToString("yyyy-MM-dd_hhmmss");
                //commit the Json and CSV file
                string repoPath = GithubService.GetRepoResultPath(UserSetting.MonicaResultsPathOnGithub);
                GithubService.CommitOnGit(fileName, answer, csvContent, UserSetting.GithubUserName, UserSetting.GithubPassword, repoPath);
            }
        }

        isDataSending = false;
        isExportDone = true;
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
#nullable restore
#line 476 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\UploadData.razor"
           



    bool showModal = false;

    void ModalShow() => showModal = true;
    void ModalCancel() => showModal = false;
    void ModalOk()
    {
        Console.WriteLine("Modal ok");
        showModal = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ZmqConsumer ZmqConsumer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ZmqProducer ZmqProducer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blzZmq1.Services.Github.IGithubService GithubService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonicaZmqService MonicaZmqService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment HostEnvironment { get; set; }
    }
}
#pragma warning restore 1591
