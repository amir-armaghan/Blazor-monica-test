using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Application.Share;
using Core.Daily;
using Core.Share;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Application.Convertor
{
    public class DailyOutputConvertor : IMonicaOutputMapper<DailyData>
    {
        public DailyData Convert(StreamReader data)
        {
            var dailyData = new DailyData();

            using (JsonTextReader reader = new JsonTextReader(data))
            {
                JObject jObject = (JObject)JToken.ReadFrom(reader);

                foreach (var mData in jObject["data"])
                {
                    string OrigSpec = (string)mData[MonicaConstFields.OrigSpec];
                    OrigSpec = OrigSpec.RemoveQuotation();

                    if (OrigSpec != MonicaConstFields.Daily)
                        continue;

                    int outputIdIndex = 0;

                    foreach (var outId in mData[MonicaConstFields.OutputIds])
                    {
                        string jsonInput = (string)outId[MonicaConstFields.JsonInput];
                        if (jsonInput == MonicaConstFields.Date)
                        {
                            foreach (var result in mData[MonicaConstFields.Results][outputIdIndex])
                            {
                                // date = System.Convert.ToDateTime(result);
                                dailyData.Dates.Add((string)result);
                            }
                        }
                        // Other OutputIds
                        else  // the result is a series of arrays
                        {
                            var outputId = new DailyOutputId();
                            outputId = GetOutputId(outId);

                            int resultLenght = outputId.ToLayer - outputId.FromLayer;

                            if (resultLenght > 0)
                            {
                                string outputIdName = outputId.Name;

                                for (int i = 0; i <= resultLenght; i++)
                                {
                                    var newOutputId = GetOutputId(outId);
                                    newOutputId.Name = outputIdName + "-" + (i + 1);

                                    foreach (var result in mData[MonicaConstFields.Results][outputIdIndex])
                                    {
                                        newOutputId.Results.Add(result[i]);
                                    }

                                    dailyData.DailyOutputIds.Add(newOutputId);
                                }
                            }
                            else // simple result
                            {
                                foreach (var result in mData[MonicaConstFields.Results][outputIdIndex])
                                {
                                    outputId.Results.Add(result);
                                }

                                dailyData.DailyOutputIds.Add(outputId);
                            }
                        }
                        outputIdIndex++;
                    }
                }
            }

            return dailyData;
        }

        private DailyOutputId GetOutputId(JToken jToken)
        {
            var outputId = new DailyOutputId();

            outputId.JsonInput = (string)jToken[MonicaConstFields.JsonInput];
            outputId.Name = (string)jToken[MonicaConstFields.Name];
            outputId.Type = (string)jToken[MonicaConstFields.Type];
            outputId.Unit = (string)jToken[MonicaConstFields.Unit];

            int output = 0;
            int.TryParse((string)jToken[MonicaConstFields.Id], out output);
            outputId.Id = output;

            output = 0;
            int.TryParse((string)jToken[MonicaConstFields.LayerAggOp], out output);
            outputId.LayerAggOp = output;

            output = 0;
            int.TryParse((string)jToken[MonicaConstFields.Organ], out output);
            outputId.Organ = output;

            output = 0;
            int.TryParse((string)jToken[MonicaConstFields.TimeAggOp], out output);
            outputId.TimeAggOp = output;

            output = 0;
            int.TryParse((string)jToken[MonicaConstFields.ToLayer], out output);
            outputId.ToLayer = output;

            return outputId;
        }
    }
}
