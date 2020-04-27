using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;


namespace blzZmq1.Services
{
    public class GetInfoFromJson
    {

        // only get the dates
        public static string GetDate()
        {
        string chartString = "";
        var chartData = JsonToChart.ConvertJson();
        
        foreach (var x in chartData.Data[0].OutputIds[0].Result)
                if (x != null)
                {
                    //Console.Write("'" + Convert.ToString(x) + "' , ");
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
                    chartString = chartString + Convert.ToString(x).Replace(",", ".") + ", ";
                 }
            
            return chartString;

        }
    }
}
