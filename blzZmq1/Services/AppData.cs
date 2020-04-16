using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace blzZmq1.Services
{
    public class AppData
    {

        // creating variables which we can access in all components (The configuration data)
        public string ServerPushAddress { get; set; } = "tcp://localhost";
        public int ServerPushPort { get; set; } = 6666;
        public string ServerPullAddress { get; set; } = "tcp://localhost";
        public int ServerPullPort { get; set; } = 7777;


        /*private const String ConfigFileName = "Config.ini";  // If a day needed an ini for storing the configuration
        
        public void readConfigFile()
        {
            var lines = File.ReadAllLines(ConfigFileName);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string s in lines)
            {
                string[] split = s.Split("=");
                dict.Add(split[0], split[1]);
            }
        }*/




    }
}
