using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace blzZmq1.Services
{
    public static class AppData
    {

        // creating variables which we can access in all components (The configuration data)
        // ZMQ pull and push addresses and ports
        public static string ServerPushAddress { get; set; } = "tcp://localhost";
        public static int ServerPushPort { get; set; } = 6666;
        public static string ServerPullAddress { get; set; } = "tcp://localhost";
        public static int ServerPullPort { get; set; } = 7777;
        public static bool ChartIsRun { get; set; } = false;
                      
        public static string GithubUserName { get; set; } = "USER NAME";
        public static string GithubPassword { get; set; } = "PASS WORD";
        public static bool GithubLoggedIn { get; set; } = false;

    }
}
