#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1099726db53dbefd8ef65bdd7ac2a2f11557078"
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
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
using blzZmq1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
using Core.MonicaData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    public partial class MonicaHighchart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Monica Chart</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorPro.Spinkit.SpinLoader>(1);
            __builder.AddAttribute(2, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
                       isLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "LoadingTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<BlazorPro.Spinkit.Chase>(5);
                __builder2.AddAttribute(6, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            ));
            __builder.AddAttribute(8, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<blzZmq1.Components.Highchart>(10);
                __builder2.AddAttribute(11, "Json", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
                          chartjson

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\MonicaCharts\MonicaHighchart.razor"
      

    bool isLoading = true;
    string chartjson;

    [Parameter]
    public MonicaSerie XAxis { get; set; } = null;

    [Parameter]
    public EventCallback<MonicaSerie> XAxisChanged { get; set; }

    [Parameter]
    public List<MonicaSerie> Series { get; set; } = null;

    [Parameter]
    public EventCallback<List<MonicaSerie>> SeriesChanged { get; set; }

    //protected override async Task OnInitializedAsync()
    protected override async Task OnInitializedAsync()
    {
        await InitialChartAsync();
        isLoading = false;
    }

    private async Task InitialChartAsync()
    {
        if (XAxis != null)
        {
            string chartTypeName = "area";  //line, area
            string chartTitleName = "Monica Model from json message";
            string chartOrigSpec = "Daily";

            string xAxsis = "";

            for (int i = 0; i < XAxis.Values.Count; i++)
            {
                xAxsis += "'" + XAxis.Values[i] + "' , ";
            }


            bool isFirstSerie = true;
            StringBuilder series = new StringBuilder("[");

            foreach (var serie in Series)
            {
                series.Append("{ name: '" + serie.SerieTitle + "', data: [");

                for (int i = 0; i < serie.Values.Count; i++)
                {
                    series.Append(serie.Values[i] + " , ");
                }

                // Only enable the first serie & let the user enable the rest if wants
                //series += "], visible: false },";
                series.Append("]");
                if (isFirstSerie)
                {
                    series.Append(" },");
                    isFirstSerie = false;
                }
                else
                {
                    series.Append(", visible: false },");
                }

            }
            series.Append("]");

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


xAxis: [{
        title: {
          text: ' '
        },
        categories: [" + xAxsis + @"],
    },
    {
        title: {
          text: ' '
        },
        categories: [' '],
    }],

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
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
