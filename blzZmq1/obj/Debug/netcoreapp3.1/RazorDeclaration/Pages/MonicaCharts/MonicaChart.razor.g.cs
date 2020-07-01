#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee96d9669d7b449c407a8c0b116ce0b2eda1927a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blzZmq1.Pages.MonicaCharts
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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Services.MonicaCharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using Core.Share.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using Core.MonicaData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Services.Github;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using Octokit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monicaCharts/monicaChart")]
    public partial class MonicaChart : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 164 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
      
    private string sharedLink;
    private bool isLoading = true;
    private string _selectedFile;
    private int? _selectedCategoryId = null;
    private Guid? _selectedXAxisId = null;
    private bool canLoadMonicaBaseData = false;
    private bool CanLoadChart = false;
    private bool isJson = true;
    private MonicaViewReultType _monicaViewReultType = MonicaViewReultType.Github;
    private IEnumerable<RepositoryContent> githubResultFilesName;

    const string DefaultStatus = "Drop your JSON file here or just click to choose you file";
    const int MaxFileSize = 12 * 1024 * 1024; // 12MB
    string status = DefaultStatus;
    string fileName;

    public List<MonicaBaseData> MonicaBaseDatas { get; set; } = null;

    public Dictionary<int, string> MonicaDataCategories { get; set; } = null;

    public List<MonicaSerie> ChartXAxises { get; set; } = null;

    [Parameter]
    public MonicaSerie ChartXAxise { get; set; } = null;

    [Parameter]
    public List<MonicaSerie> ChartSeries { get; set; } = null;

    protected override async Task OnInitializedAsync()
    {
        UserSettingsUpdated += OnAfterUserSettingsUpdatedAsync;
        isLoading = false;
    }

    void OnAfterUserSettingsUpdatedAsync(object sender, EventArgs e)
    {
        if (UserSetting.GithubLoggedIn)
        {
            GithubService.SetRepoInfo(UserSetting.MonicaResultsPathOnGithub);
            string repoPath = GithubService.GetRepoPath(UserSetting.MonicaResultsPathOnGithub);
            githubResultFilesName = GithubService.GetContents(repoPath, UserSetting.GithubUserName, UserSetting.GithubPassword);
            githubResultFilesName = githubResultFilesName.Where(s => s.Type == ContentType.File && s.Name.Contains(".json"));
        }
        StateHasChanged();
    }

    void MonicaViewResultTypeChanged()
    {
        UnloadMonicaBaseData();
    }

    private long GetTheLength(bool isJson)
    {
        long length;
        if (isJson == true)
        {
            length = new System.IO.FileInfo(System.IO.Path.GetFullPath(_selectedFile)).Length / 1024;
        }
        else
        {
            length = new System.IO.FileInfo(System.IO.Path.GetFullPath(System.IO.Path.ChangeExtension(_selectedFile, "csv"))).Length / 1024;
        }
        return (length);
    }

    private void UnloadMonicaBaseData()
    {
        canLoadMonicaBaseData = false;
        UnloadChart();
    }

    private void UnloadChart()
    {
        CanLoadChart = false;
    }

    async Task MonicaResultsFromGithubChanged(ChangeEventArgs e)
    {
        if (e.Value.ToString() == "-1")
        {
            _selectedFile = null;
        }

        _selectedFile = e.Value.ToString();
        GithubService.SetRepoInfo(UserSetting.MonicaResultsPathOnGithub);

        var monicaResultFile = githubResultFilesName.Where(s => s.Path == _selectedFile).First();

        var monicaResultContent = await GithubService.GetFileContentUsingShaAsync(monicaResultFile.Sha, UserSetting.GithubUserName, UserSetting.GithubPassword);

        LoadMonicaBaseData(monicaResultContent);
    }

    async Task LoadFromSharedLink(string sharedLink)
    {
        var fileContent = await FileUpload.GetFileContentAsync(sharedLink);

        if (fileContent != null)
        {
            LoadMonicaBaseData(fileContent);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    private void LoadMonicaBaseData(string monicaResultContent)
    {
        UnloadChart();
        _selectedCategoryId = null;
        _selectedXAxisId = null;
        canLoadMonicaBaseData = true;

        MonicaBaseDatas = MonicaChartService.GetBaseDataFromJson(monicaResultContent);
        MonicaDataCategories = MonicaBaseDatas.ToDictionary(s => s.Id, o => o.OrigSpec);
    }

    private void ChangeDataCategory(ChangeEventArgs e)
    {
        UnloadChart();
        _selectedXAxisId = null;

        if (string.IsNullOrWhiteSpace(e.Value.ToString()))
        {
            _selectedCategoryId = null;
            return;
        }

        _selectedCategoryId = Convert.ToInt32(e.Value);

        var monicaBaseData = MonicaBaseDatas.First(s => s.Id == _selectedCategoryId);
        ChartXAxises = MonicaChartService.GetXAxises(monicaBaseData);
        ChartSeries = MonicaChartService.GetSeries(monicaBaseData);
    }

    private void ChangeXAxis(ChangeEventArgs e)
    {
        UnloadChart();

        if (string.IsNullOrWhiteSpace(e.Value.ToString()))
        {
            _selectedXAxisId = null;
            return;
        }

        _selectedXAxisId = new Guid(e.Value.ToString());
    }

    public void DrawChart()
    {

        if (_selectedXAxisId != null)
        {
            ChartXAxise = ChartXAxises.First(s => s.Id == _selectedXAxisId);
            CanLoadChart = true;

        }
    }

    ///  upload json, read to memory and call to load the chart
    private async Task HandleFile(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file == null)
        {
            return;
        }
        else if (file.Size > MaxFileSize)
        {
            status = $"That's too big. Max size: {MaxFileSize} bytes.";
        }
        else
        {
            status = "Loading...";

            await ReadFileContentAsync(file);

            status = $"Finished loading {file.Size} bytes from {file.Name}";

        }
    }

    async Task ReadFileContentAsync(IFileListEntry file)
    {
        string fileTextContents = string.Empty;

        using (var reader = new StreamReader(file.Data))
        {
            fileTextContents = await reader.ReadToEndAsync(); //.ConfigureAwait(false); //.ConfigureAwait(continueOnCapturedContext: false);
            fileName = file.Name;
        }

        if (fileTextContents != null)
        {
            LoadMonicaBaseData(fileTextContents);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGithubService GithubService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonicaChartService MonicaChartService { get; set; }
    }
}
#pragma warning restore 1591
