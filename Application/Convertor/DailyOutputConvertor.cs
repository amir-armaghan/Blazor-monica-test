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
                    //if (OrigSpec == MonicaConstFields.Daily)
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
                        else  
                        {
                            var outputId = new DailyOutputId();
                            outputId = GetOutputId(outId);

                            var results = (JArray)mData[MonicaConstFields.Results][outputIdIndex];
                            
                            if (results.Count > 0)
                            {
                                var firstResult = results[0];

                                if (firstResult is JArray) // the result is a series of arrays
                                {
                                    string outputIdName = outputId.Name;

                                    for (int i = 0; i < ((JArray)firstResult).Count; i++)
                                    {
                                        var newOutputId = GetOutputId(outId);
                                        newOutputId.Name = outputIdName + "-" + (i + 1);

                                        foreach (var result in results)
                                        {
                                            
                                            newOutputId.Results.Add(result[i].ToString().Replace(",", "."));
                                        }

                                        dailyData.DailyOutputIds.Add(newOutputId);
                                    }
                                }
                                else
                                {
                                    foreach (var result in results)
                                    {
                                        outputId.Results.Add(result.ToString().Replace(",", "."));
                                    }

                                    dailyData.DailyOutputIds.Add(outputId);
                                }
                            }
                        }
                        outputIdIndex++;
                    }
                    //else if (OrigSpec == MonicaConstFields.Yearly)
                    // Do for yearly
                    //else if (OrigSpec == MonicaConstFields.Monthly)
                    //Do for Monthly
                    //else 
                        //Do something for the rest
                }
            }

            return dailyData; //return data for selected chart
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
