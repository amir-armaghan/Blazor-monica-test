using Core.Daily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blzZmq1.Services.ChartData
{
    interface IDailyChartService
    {
        //Task<DailyData> GetDailyChartDataAsync();
        Task<DailyData> GetDailyChartDataAsync(string jsonToChartPath);
    }
}
