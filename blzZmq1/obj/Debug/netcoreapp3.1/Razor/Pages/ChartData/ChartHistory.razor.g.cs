#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083b70ba6d3050a40438feb6fdde40799f3fc792"
// <auto-generated/>
#pragma warning disable 1591
namespace blzZmq1.Pages.ChartData
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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
using blzZmq1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
using blzZmq1.Services.ChartData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
using Core.Daily;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chartdata/charthistory")]
    public partial class ChartHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daily Chart</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Download CSV</th>\r\n            <th>Load Chart</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 24 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
         for (int i = 0; i < dirsLenght; i++)
        {
            var buttonNumber = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
                     System.IO.Path.GetFileNameWithoutExtension(dirs[i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 29 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
                              System.IO.Path.ChangeExtension(dirs[i].Substring(dirs[i].IndexOf("/")), "csv")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, "CSV file");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
                                        () => LoadChart(buttonNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Load Chart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 32 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenComponent<BlazorPro.Spinkit.SpinLoader>(27);
            __builder.AddAttribute(28, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
                       isLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "LoadingTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<BlazorPro.Spinkit.Chase>(31);
                __builder2.AddAttribute(32, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n    ");
            }
            ));
            __builder.AddAttribute(34, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<blzZmq1.Components.Highchart>(36);
                __builder2.AddAttribute(37, "Json", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
                          chartjson

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\ChartHistory.razor"
      

    string str;
    string filesTable = "";
    int dirsLenght;
    string[] dirs;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        dirs = Directory.GetFiles(@"wwwroot/export/", "*.json");
        dirsLenght = dirs.Length;
    }


    Boolean isLoading = true;
    private DailyData dailyData = null;
    string chartjson;
    //public string jsonToChartPath = "Data/fromServer.json"; 
    public string jsonToChartPath = "wwwroot/export/last.json";

    protected async Task LoadChart(int item)
    {
        isLoading = true;
        // get back the file name from item number:
        jsonToChartPath = dirs[item];
        await DrawChart();
        isLoading = false;
        StateHasChanged();


    }
    async Task GetListOfFiles()
    {

    }

    //protected override async Task OnInitializedAsync()
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await DrawChart();
        }
        if (isLoading)  // prevent a forever loop
        {
            isLoading = false;
            StateHasChanged();
        }
        //isLoading = false;
        //StateHasChanged();
    }

    protected async Task DrawChart()
    {

        dailyData = await DailyChartService.GetDailyChartDataAsync(jsonToChartPath);

        string chartTypeName = "area";  // has to get from json
        string chartTitleName = "Monica Model from json message";
        string chartOrigSpec = "Daily";

        string xAxsis = "";


        for (int i = 0; i < dailyData.Dates.Count; i++)
        {
            xAxsis += "'" + dailyData.Dates[i] + "' , ";
        }

        Boolean isFirstSerie = true;
        string series = "[";
        foreach (var outputId in dailyData.DailyOutputIds)
        {
            if (outputId.Name == Core.Share.MonicaConstFields.Crop)
                continue;

            series += "{ name: '" + outputId.Name + "', data: [";

            for (int i = 0; i < outputId.Results.Count; i++)
            {
                series += outputId.Results[i].ToString().Replace(",", ".") + " , ";
            }

            // Only enable the first serie & let the user enable the rest if wants
            //series += "], visible: false },";
            series += "]";
            if (isFirstSerie)
            {
                series += " },";
                isFirstSerie = false;
            }
            else
            {
                series += ", visible: false },";
            }

        }
        series += "]";

        chartjson = @" {
chart: {
zoomType: 'x',
height: 600,
type: '" + chartTypeName + @"',

},
colors: [
'#063c75',
'#1c8c44',
'#881452',
'#280137',
'#63a194',
'#2c3539',
'#428bca',
'#d9534f',
'#96ceb4',
'#80699B',
'#3D96AE',
'#DB843D',
'#92A8CD',
'#A47D7C',
'#B5CA92'],
loading: {
hideDuration: 1000,
showDuration: 1000
},
title: {
text: '" + chartTitleName + @"'
},

subtitle: {
text: '" + chartOrigSpec + @"'
},

yAxis: {
title: {
text: ' '
},
maxZoom: 2
},

xAxis: {
title: {
text: 'Date'
},
categories: [" + xAxsis + @"],
},

legend: {
layout: 'vertical',
align: 'right',
verticalAlign: 'middle'
},

plotOptions: {
area: {
fillColor: {
linearGradient: {
    x1: 0,
    y1: 0,
    x2: 0,
    y2: 0.6
 },
stops: [
        [0, Highcharts.getOptions().colors[0]],
        [1, Highcharts.color(Highcharts.getOptions().colors[0]).setOpacity(0).get('rgba')]
    ]
},
marker: {
radius: 2
},
lineWidth: 1,
states: {
hover: {
lineWidth: 1
}
},
threshold: null
}
},

series:" + series + @",

responsive: {
rules: [{
condition: {
maxWidth: 500
},
chartOptions: {
legend: {
layout: 'horizontal',
align: 'center',
verticalAlign: 'bottom'
}
}
}]
},
navigation: {
buttonOptions: {
align: 'right'
}
},
exporting: {
sourceWidth: 1600,
scale: 1
},


}";
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDailyChartService DailyChartService { get; set; }
    }
}
#pragma warning restore 1591
