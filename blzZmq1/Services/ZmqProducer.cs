using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace blzZmq1.Services
{
    public class ZmqProducer
    {
        public static string RunProducer()            
        {
           

            /* string currentDir = Path.GetDirectoryName(Application.ExecutablePath);
             Dictionary<string, string> config = new Dictionary<string, string>();
             config.Add("port", string.IsNullOrEmpty(port) ? "6666" : port);
             config.Add("server", string.IsNullOrEmpty(server) ? "localhost" : port);
             config.Add("sim.json", Path.Combine(currentDir, "sim.json"));
             config.Add("crop.json", Path.Combine(currentDir, "crop.json"));
             config.Add("site.json", Path.Combine(currentDir, "site.json"));
             config.Add("climate.csv", Path.Combine(currentDir, "climate.csv"));
             config.Add("shared_id", shared_id);*/

            //var socket = new ZeroMQ.ZSocket(ZeroMQ.ZSocketType.PUSH);
            //socket.Connect("tcp://" + config["server"] + ":" + config["port"]);


            //convert the following codes into static addresses:
            //var sim_json = JObject.Parse(File.ReadAllText(config["sim.json"])); 
            //var site_json = JObject.Parse(File.ReadAllText(config["site.json"]));
            //var crop_json = JObject.Parse(File.ReadAllText(config["crop.json"]));
            //string climate_csv = File.ReadAllText(config["climate.csv"]);

            var sim_json = JObject.Parse(File.ReadAllText("Data/sim.json"));
            var site_json = JObject.Parse(File.ReadAllText("Data/site.json"));
            var crop_json = JObject.Parse(File.ReadAllText("Data/crop.json"));
            string climate_csv = File.ReadAllText("Data/climate.csv");



            JObject crop_site_sim = new JObject();
            crop_site_sim.Add("crop", crop_json);
            crop_site_sim.Add("site", site_json);
            crop_site_sim.Add("sim", sim_json);
            crop_site_sim.Add("climate", "");
            //crop_site_sim.Add("climate", climate_csv);

            var env = MonicaIO.create_env_json_from_json_config(crop_site_sim);
            if (env != null)
            {
                //env.Add("csvViaHeaderOptions", sim_json["climate.csv-options"]);
                //env.Add("pathToClimateCSV", "C:/Users/armaghan/source/repos/blzZmq1/blzZmq1/Data/climate.csv");
                env["pathToClimateCSV"] = "C:/Users/armaghan/source/repos/blzZmq1/blzZmq1/Data/climate.csv";

                //socket.SendFrame(new ZFrame(Encoding.UTF8.GetBytes(env.ToString())));
                // Send frame by NetMQ

                //Console.WriteLine("Done!");
                string env2 = env.ToString();
                return env2;
            }
            return null;  // when env is null
        }
    }

}
