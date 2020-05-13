using Application.MonicaCharts;
using Core.MonicaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blzZmq1.Services.MonicaCharts
{
    public interface IMonicaChartService
    {
        Task<string[]> GetExportedFilesAsync();

        Task<List<MonicaBaseData>> GetBaseDataAsync(string filePath);

        List<MonicaSerie> GetXAxises(MonicaBaseData monicaBaseData);

        List<MonicaSerie> GetSeries(MonicaBaseData monicaBaseData);
    }
}
