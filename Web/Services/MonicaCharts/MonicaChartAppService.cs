using Services.Convertor;
using Models.MonicaData;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Services.MonicaCharts
{
    public class MonicaChartAppService : IMonicaChartAppService
    {
        private readonly IMonicaJsonMapperService _monicaJsonMapper;

        public MonicaChartAppService(IMonicaJsonMapperService monicaJsonMapper)
        {
            _monicaJsonMapper = monicaJsonMapper;
        }

        public async Task<List<MonicaBaseData>> GetAsync(string monicaJsonFilePath)
        {
            using (StreamReader file = File.OpenText(monicaJsonFilePath))
            {
                return _monicaJsonMapper.Map(file);
            }
        }
    }
}
