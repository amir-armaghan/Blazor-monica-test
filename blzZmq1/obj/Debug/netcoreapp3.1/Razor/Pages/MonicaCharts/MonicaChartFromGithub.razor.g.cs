#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11057e04267295697e09e20e73893bf5045e9ff"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
using blzZmq1.Services.MonicaCharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
using Core.MonicaData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
using Core.Share;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monicaCharts/monicaGitChart")]
    public partial class MonicaChartFromGithub : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Monica Results From your github repository</h3>\r\n");
            __builder.AddMarkupContent(1, "<h4>Last 15 results</h4>\r\n\r\n");
            __builder.OpenComponent<BlazorPro.Spinkit.SpinLoader>(2);
            __builder.AddAttribute(3, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                       isLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "LoadingTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<BlazorPro.Spinkit.Chase>(6);
                __builder2.AddAttribute(7, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 23 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
         if (dirsLenght > 0)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "select");
                __builder2.AddAttribute(16, "class", "form-control p-2 m-2");
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                LoadMonicaBaseDataAsync

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "option");
                __builder2.AddAttribute(20, "value", "-1");
                __builder2.AddContent(21, "Select a file");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n");
#nullable restore
#line 28 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                     for (int i = (dirsLenght > 15) ? dirsLenght - 15 : 0; i < dirsLenght; i++)
                    {
                        var fileIndex = i;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(23, "                        ");
                __builder2.OpenElement(24, "option");
                __builder2.AddAttribute(25, "value", "0");
                __builder2.AddContent(26, "null");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 32 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n");
#nullable restore
#line 35 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
             if (string.IsNullOrWhiteSpace(_selectedFile) == false)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(31, "                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "alert-dark m-1 rounded small");
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "table");
                __builder2.AddAttribute(36, "class", "table");
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.AddMarkupContent(38, @"<thead>
                            <tr>
                                <th>Result Name</th>
                                <th>Created Time</th>
                                <th>Json download link - size</th>
                                <th>CSV download link - size</th>
                            </tr>
                        </thead>
                        ");
                __builder2.OpenElement(39, "tbody");
                __builder2.AddMarkupContent(40, "\r\n\r\n                            ");
                __builder2.OpenElement(41, "tr");
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenElement(43, "td");
                __builder2.AddContent(44, 
#nullable restore
#line 50 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                     System.IO.Path.GetFileNameWithoutExtension(_selectedFile)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                ");
                __builder2.OpenElement(46, "td");
                __builder2.AddContent(47, 
#nullable restore
#line 51 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                     System.IO.File.GetCreationTime(System.IO.Path.GetFullPath(_selectedFile))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                ");
                __builder2.OpenElement(49, "td");
                __builder2.OpenElement(50, "a");
                __builder2.AddAttribute(51, "target", "_blank");
                __builder2.AddAttribute(52, "href", 
#nullable restore
#line 52 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                              _selectedFile.Substring(_selectedFile.IndexOf("/"))

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(53, "Json file");
                __builder2.CloseElement();
                __builder2.AddContent(54, ", Size: ");
                __builder2.AddContent(55, 
#nullable restore
#line 52 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                                                                                         GetTheLength(true)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(56, " KB");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                ");
                __builder2.OpenElement(58, "td");
                __builder2.OpenElement(59, "a");
                __builder2.AddAttribute(60, "target", "_blank");
                __builder2.AddAttribute(61, "href", 
#nullable restore
#line 53 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                              System.IO.Path.ChangeExtension(_selectedFile.Substring(_selectedFile.IndexOf("/")), "csv")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(62, "CSV file");
                __builder2.CloseElement();
                __builder2.AddContent(63, ", Size: ");
                __builder2.AddContent(64, 
#nullable restore
#line 53 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                                                                                                                               GetTheLength(false)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(65, "  KB");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n");
                __builder2.AddContent(71, "                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "input-group mb-3");
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.AddMarkupContent(75, "<div class=\"input-group-prepend\">\r\n                        <span class=\"input-group-text\" id=\"basic-addon3\">Chart Group</span>\r\n                    </div>\r\n                    ");
                __builder2.OpenElement(76, "select");
                __builder2.AddAttribute(77, "id", "dataCategory");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                              ChangeDataCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.OpenElement(81, "option");
                __builder2.AddAttribute(82, "selected", 
#nullable restore
#line 64 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                            _selectedCategoryId == null

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n");
#nullable restore
#line 65 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                         foreach (var dataCategory in MonicaDataCategories)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(85, "                            ");
                __builder2.OpenElement(86, "option");
                __builder2.AddAttribute(87, "value", 
#nullable restore
#line 67 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                           dataCategory.Key

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(88, 
#nullable restore
#line 67 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                             dataCategory.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n");
#nullable restore
#line 68 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(90, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n");
#nullable restore
#line 72 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                 if (_selectedCategoryId != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(93, "                    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "input-group mb-3");
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.AddMarkupContent(97, "<div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\" id=\"basic-addon3\">Chart\'s x Axis</span>\r\n                        </div>\r\n                        ");
                __builder2.OpenElement(98, "select");
                __builder2.AddAttribute(99, "id", "chartXAxis");
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                                ChangeXAxis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(102, "\r\n                            ");
                __builder2.OpenElement(103, "option");
                __builder2.AddAttribute(104, "selected", 
#nullable restore
#line 79 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                _selectedCategoryId == null

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(105, "class", "form-control");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n");
#nullable restore
#line 80 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                             foreach (var chartXAxis in ChartXAxises)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(107, "                                ");
                __builder2.OpenElement(108, "option");
                __builder2.AddAttribute(109, "value", 
#nullable restore
#line 82 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                chartXAxis.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(110, 
#nullable restore
#line 82 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                chartXAxis.SerieTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n");
#nullable restore
#line 83 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(112, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n");
#nullable restore
#line 87 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                     if (_selectedXAxisId != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(115, "                        ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "class", "btn btn-primary m-1");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                      DrawChart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(119, "Draw The Chart");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n");
#nullable restore
#line 90 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                 

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
             
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(121, "\r\n");
#nullable restore
#line 96 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
         if (CanLoadChart)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "            ");
                __builder2.OpenComponent<blzZmq1.Pages.MonicaCharts.MonicaHighchart>(123);
                __builder2.AddAttribute(124, "XAxis", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Core.MonicaData.MonicaSerie>(
#nullable restore
#line 98 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                          ChartXAxise

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(125, "XAxisChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Core.MonicaData.MonicaSerie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Core.MonicaData.MonicaSerie>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ChartXAxise = __value, ChartXAxise))));
                __builder2.AddAttribute(126, "Series", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Core.MonicaData.MonicaSerie>>(
#nullable restore
#line 98 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
                                                                     ChartSeries

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "SeriesChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<Core.MonicaData.MonicaSerie>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<Core.MonicaData.MonicaSerie>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ChartSeries = __value, ChartSeries))));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(128, "\r\n");
#nullable restore
#line 99 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(129, "    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaChartFromGithub.razor"
      
    private int dirsLenght;
    private object dirs;
    private bool isLoading = true;
    private string _selectedFile;
    private int? _selectedCategoryId = null;
    private Guid? _selectedXAxisId = null;
    private bool CanLoadChart = false;
    private bool isJson = true;

    public List<MonicaBaseData> MonicaBaseDatas { get; set; } = null;

    public Dictionary<int, string> MonicaDataCategories { get; set; } = null;

    public List<MonicaSerie> ChartXAxises { get; set; } = null;

    [Parameter]
    public MonicaSerie ChartXAxise { get; set; } = null;

    [Parameter]
    public List<MonicaSerie> ChartSeries { get; set; } = null;


    protected override async Task OnInitializedAsync()
    {
        dirs = GithubService.GetContentsList("armaghan-monica-params", UserSetting.GithubUserName, UserSetting.MonicaResultsPathOnGithub);
        //dirsLenght = dirs.Length;
        isLoading = false;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blzZmq1.Services.Github.IGithubService GithubService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonicaChartService MonicaChartService { get; set; }
    }
}
#pragma warning restore 1591
