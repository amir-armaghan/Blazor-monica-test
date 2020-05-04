#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\DailyChart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94c1c850aaa2b216732fe1cf9c7f3297ca3f8567"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\DailyChart.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\DailyChart.razor"
using blzZmq1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\DailyChart.razor"
using blzZmq1.Services.ChartData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\DailyChart.razor"
using Core.Daily;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chartdata/dailychart")]
    public partial class DailyChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\ChartData\DailyChart.razor"
      

    
    Boolean isLoading = true;
    private DailyData dailyData = null;
    string chartjson;

    //protected override async Task OnInitializedAsync()
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {

            dailyData = await DailyChartService.GetDailyChartDataAsync();

            string chartTypeName = "area";  // has to get from json
            string chartTitleName = "Monica Model from json message";
            string chartOrigSpec = "Daily";

            string xAxsis = "";


            for (int i = 0; i < dailyData.Dates.Count; i++)
            {
                xAxsis += "'" + dailyData.Dates[i] + "' , ";
            }

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

                series += "] },";

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
        if (isLoading)  // prevent a forever loop
        {
            isLoading = false;
            StateHasChanged();
        }
        //isLoading = false;
        //StateHasChanged(); 
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDailyChartService DailyChartService { get; set; }
    }
}
#pragma warning restore 1591
