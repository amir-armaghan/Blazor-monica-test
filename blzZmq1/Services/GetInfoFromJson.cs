using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

// Converts json result from server to array to send to Highchart
// this is just for test and getting the variables staticly. it has to understand variables/valiable names dynamicly and send to highchart
namespace blzZmq1.Services
{
    public class GetInfoFromJson
    {

        // only get the dates
        public static string GetDate()
        {
        string chartString = "";
        var chartData = JsonToChart.ConvertJson();
        
        // get the dates to have it as xAxsis
        foreach (var x in chartData.Data[0].OutputIds[0].Result)
                if (x != null)
                {
                    //Console.Write("'" + Convert.ToString(x) + "' , ");
                    // Highchart understands this array if it is separated by , 
                    chartString = chartString + "'" + Convert.ToString(x) + "' , ";


                }
        return chartString;

        }

        public static string GetPrecip() //only for test
        {
            string chartString = "";
            var chartData = JsonToChart.ConvertJson();

            //string chartString = string.Join(",", chartData.Data[0].OutputIds[8].Result as List<object[]>.ToList<float[]>());
            //var y = chartData.Data[0].OutputIds[8].Result[550]; // 8.5

             foreach (var x in chartData.Data[0].OutputIds[8].Result)
                 if (x != null)
                 {
                    // float numbers for highchart should be like 2.5 not 2,5
                    chartString = chartString + Convert.ToString(x).Replace(",", ".") + ", ";
                 }
            
            return chartString;

        }
    }
}
