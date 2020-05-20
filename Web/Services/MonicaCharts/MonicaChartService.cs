using Services.MonicaCharts;
using Models.MonicaData;
using Models.Share;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services.MonicaCharts
{
    public class MonicaChartService : IMonicaChartService
    {
        private readonly IMonicaChartAppService _monicaChartApp;

        public MonicaChartService(IMonicaChartAppService monicaChartApp)
        {
            _monicaChartApp = monicaChartApp;
        }

        public async Task<List<MonicaBaseData>> GetBaseDataAsync(string filePath)
        {
            return await _monicaChartApp.GetAsync(filePath);
        }

        public List<MonicaSerie> GetXAxises(MonicaBaseData monicaBaseData)
        {
            var monicaSeries = new List<MonicaSerie>();
            var monicaConstField = new MonicaConstFields();

            foreach (var monicaSerie in monicaBaseData.MonicaSeries)
            {
                if (monicaSerie.Values.Count == 0)
                    continue;
                if (monicaConstField.XAxiesNames.Contains(monicaSerie.SerieTitle.ToLower()))
                {
                    monicaSeries.Add(monicaSerie);
                }
                else
                {
                    double tempValue;
                    bool isNumeric = double.TryParse(monicaSerie.Values[0], out tempValue);
                    if (!isNumeric)
                    {
                        monicaSeries.Add(monicaSerie);
                    }
                }
            }

            return monicaSeries;
        }

        public List<MonicaSerie> GetSeries(MonicaBaseData monicaBaseData)
        {
            var monicaConstField = new MonicaConstFields();
            var monicaSeries = new List<MonicaSerie>();

            foreach (var monicaSerie in monicaBaseData.MonicaSeries)
            {
                if (monicaSerie.Values.Count == 0 ||
                    monicaConstField.XAxiesNames.Contains(monicaSerie.SerieTitle.ToLower()))
                    continue;

                double tempValue;
                bool isNumeric = double.TryParse(monicaSerie.Values[0], out tempValue);
                if (isNumeric)
                {
                    monicaSeries.Add(monicaSerie);
                }
            }

            return monicaSeries;
        }

        public async Task<string[]> GetExportedFilesAsync()
        {
            return await Task.FromResult(Directory.GetFiles(@"wwwroot/export/", "*.json"));
        }
    }
}
