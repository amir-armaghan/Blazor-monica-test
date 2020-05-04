using Application.Convertor;
using Core.Daily;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Application.ChartData
{
    public class DailyChartDataApp : IChartDataApp<DailyData>
    {
        private readonly IMonicaOutputMapper<DailyData> _dailyOutputConvertor;

        public DailyChartDataApp(
            IMonicaOutputMapper<DailyData> dailyOutputConvertor
            )
        {
            _dailyOutputConvertor = dailyOutputConvertor;
        }

        public DailyData GetChartDataFromFile(string filePath)
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                return _dailyOutputConvertor.Convert(file);
            }
        }
    }
}
