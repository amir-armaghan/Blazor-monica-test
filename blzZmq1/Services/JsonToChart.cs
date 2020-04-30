using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace blzZmq1.Services
{
    public class JsonToChart
        {    
           

    public static ChartData ConvertJson()
        {
            string schemaJson = File.ReadAllText(@"Data/jsonSchema.schema.json");
            JsonSchema schema = JsonSchema.Parse(schemaJson);
            var chartData = new ChartData();

            using (StreamReader file = File.OpenText(@"Data/fromServer.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject jObject = (JObject)JToken.ReadFrom(reader);

                    // Validating the JSON file structure by comparing it with the schema file
                    if (jObject.IsValid(schema))
                    {
                        Console.WriteLine("Jaon file is not valid.");
                    }
                    else
                    {
                        chartData.CustomId = jObject[ConvertToPascalCase(nameof(ChartData.CustomId))];
                        chartData.Errors = jObject[ConvertToPascalCase(nameof(ChartData.Errors))] as IList<object>;
                        chartData.Type = (string)jObject[ConvertToPascalCase(nameof(ChartData.Type))];
                        chartData.Warnings = jObject[ConvertToPascalCase(nameof(ChartData.Warnings))] as IList<object>;

                        foreach (var mData in jObject["data"])
                        {

                            if (chartData.Data == null)
                                chartData.Data = new List<MainData>();

                            var mainData = new MainData();

                            mainData.OrigSpec = (string)mData[ConvertToPascalCase(nameof(mainData.OrigSpec))];

                            int resultIndex = 0;

                            foreach (var outId in mData[ConvertToPascalCase(nameof(mainData.OutputIds))])
                            {
                                if (mainData.OutputIds == null)
                                    mainData.OutputIds = new List<OutputId>();

                                var outputId = new OutputId();

                                outputId.Id = (int)outId[ConvertToPascalCase(nameof(outputId.Id))];
                                outputId.JsonInput = (string)outId[ConvertToPascalCase(nameof(outputId.JsonInput))];
                                outputId.LayerAggOp = (int)outId[ConvertToPascalCase(nameof(outputId.LayerAggOp))];
                                outputId.Name = (string)outId[ConvertToPascalCase(nameof(outputId.Name))];
                                outputId.Organ = (int)outId[ConvertToPascalCase(nameof(outputId.Organ))];
                                outputId.TimeAggOp = (int)outId[ConvertToPascalCase(nameof(outputId.TimeAggOp))];
                                outputId.ToLayer = (int)outId[ConvertToPascalCase(nameof(outputId.ToLayer))];
                                outputId.Type = (string)outId[ConvertToPascalCase(nameof(outputId.Type))];
                                outputId.Unit = (string)outId[ConvertToPascalCase(nameof(outputId.Unit))];

                                //outputId.Result = ((JArray)mData[ConvertToPascalCase("results")][resultIndex++]).ToList<object>();

                                mainData.OutputIds.Add(outputId);
                            }

                            foreach (var resId in mData[ConvertToPascalCase(nameof(mainData.Results))])
                            {
                                if (mainData.Results == null)
                                    mainData.Results = new List<Results>();

                                var results = new Results();

                                results.Result = ((JArray)mData[ConvertToPascalCase("results")][resultIndex++]).ToList<object>();

                                mainData.Results.Add(results);
                            }

                            chartData.Data.Add(mainData);
                        }
                    }
                }
            }

            return chartData;
        }

        static string ConvertToPascalCase(string str)
        {
            char firstLetter = char.ToLower(str[0]);
            return firstLetter + str.Substring(1, str.Length - 1);
        }

    }

 

    public class ChartData
    {
        public object CustomId { get; set; }
        public IList<MainData> Data { get; set; }
        public IList<object> Errors { get; set; }
        public string Type { get; set; }
        public IList<object> Warnings { get; set; }
    }

    public class MainData
    {
        public string OrigSpec { get; set; }
        public IList<OutputId> OutputIds { get; set; }
        public IList<Results> Results { get; set; }
    }

    public class OutputId
    {
        public string DisplayName { get; set; }
        public int FromLayer { get; set; }
        public int Id { get; set; }
        public string JsonInput { get; set; }
        public int LayerAggOp { get; set; }
        public string Name { get; set; }
        public int Organ { get; set; }
        public int TimeAggOp { get; set; }
        public int ToLayer { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        //public IList<object> Result { get; set; }
    }

    public  class Results
    {
        public IList<object> Result { get; set; }
        //public IList<Results2> Result { get; set; }
    }

    public class Results2
    {
        public float Result2 { get; set; }
    }

}
