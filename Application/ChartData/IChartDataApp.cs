using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ChartData
{
    public interface IChartDataApp<T>
    {
        T GetChartDataFromFile(string filePath);
    }
}
