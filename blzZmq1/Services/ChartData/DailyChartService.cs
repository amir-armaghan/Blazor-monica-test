using Application.ChartData;
using Application.Convertor;
using Core.Daily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace blzZmq1.Services.ChartData
{
    public class DailyChartService : IDailyChartService
    {
        //public async Task<DailyData> GetDailyChartDataAsync()
        public async Task<DailyData> GetDailyChartDataAsync(string jsonToChartPath)
        {
            var dailyChartDataApp = new DailyChartDataApp(new DailyOutputConvertor());
            //return dailyChartDataApp.GetChartDataFromFile(@"Data/fromServer.json");
            return dailyChartDataApp.GetChartDataFromFile(jsonToChartPath);
        }
    }
}
