using Models.MonicaData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.MonicaCharts
{
    public interface IMonicaChartAppService
    {
        Task<List<MonicaBaseData>> GetAsync(string monicaJsonFilePath);
    }
}
