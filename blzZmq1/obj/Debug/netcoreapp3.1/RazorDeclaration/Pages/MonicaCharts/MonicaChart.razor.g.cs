#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc75a512d7318b81d8346c59e04cc221c0277d4a"
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
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using blzZmq1.Services.MonicaCharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
using Core.MonicaData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monicaCharts/monicaChart")]
    public partial class MonicaChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChart.razor"
      
    private int dirsLenght;
    private string[] dirs;
    private bool isLoading = true;
    private string _selectedFile;
    private int? _selectedCategoryId = null;
    private Guid? _selectedXAxisId = null;
    private bool CanLoadChart = false;

    public List<MonicaBaseData> MonicaBaseDatas { get; set; } = null;

    public Dictionary<int, string> MonicaDataCategories { get; set; } = null;

    public List<MonicaSerie> ChartXAxises { get; set; } = null;

    [Parameter]
    public MonicaSerie ChartXAxise { get; set; } = null;

    [Parameter]
    public List<MonicaSerie> ChartSeries { get; set; } = null;

    protected override async Task OnInitializedAsync()
    {
        dirs = await MonicaChartService.GetExportedFilesAsync();
        dirsLenght = dirs.Length;
        isLoading = false;
    }

    private long GetTheLength()
    {
        long length = new System.IO.FileInfo(System.IO.Path.GetFullPath(_selectedFile)).Length / 1024;
        return (length);
    }


    private void UnloadChart()
    {
        CanLoadChart = false;
    }

    private async Task LoadMonicaBaseDataAsync(ChangeEventArgs e)
    {
        UnloadChart();
        _selectedCategoryId = null;
        _selectedXAxisId = null;

        if (e.Value.ToString() == "-1")
        {
            _selectedFile = null;
            return;
        }

        _selectedFile = e.Value.ToString();
        MonicaBaseDatas = await MonicaChartService.GetBaseDataAsync(_selectedFile);
        MonicaDataCategories = MonicaBaseDatas.ToDictionary(s => s.Id, o => o.OrigSpec);

        //var result = new Dictionary<int, string>();
        //foreach (var s in MonicaBaseDatas)
        //{
        //    result.Add(s.Id, s.OrigSpec);
        //}
        //MonicaDataCategories = result;
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonicaChartService MonicaChartService { get; set; }
    }
}
#pragma warning restore 1591
