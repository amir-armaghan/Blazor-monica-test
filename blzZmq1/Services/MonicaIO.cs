using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace blzZmq1.Services
{
    public class MonicaIO
    {

        dynamic dyn;
        string json_sim = @"Data/sim.json";
        string json_site = @"Data/site.json";
        string json_crop = @"Data/crop.json";
        string csv_climate = @"Data/climate.csv";
        FileStream inputStream = new FileStream("sim.json", FileMode.Open);

        //protected override void ReadJsons()
       // {
         //   dyn = JsonConvert.DeserializeObject(json_sim);
            // ... read the rest
       // }
    }
    

}
