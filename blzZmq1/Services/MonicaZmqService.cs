using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blzZmq1.Services
{
    public class MonicaParameters : IMonicaZmqService
    {
        private readonly string ServerPushAddress;
        private readonly int ServerPushPort;
        private readonly IUserSettingsService _userSettingsService;

        public MonicaParameters(IUserSettingsService userSettingsService)
        {
            _userSettingsService = userSettingsService;
            ServerPushAddress = _userSettingsService.ServerPushAddress;
            ServerPushPort = _userSettingsService.ServerPushPort;
        }

        public Task Recieve()
        {
            throw new NotImplementedException();
        }

        public bool Send(string message)
        {
            try
            {
                using (var producer = new PushSocket())
                {
                    producer.Connect(ServerPushAddress + ":" + ServerPushPort);
                    producer.SendFrame(message);
                    System.Threading.Thread.Sleep(2000);
                    producer.Disconnect(ServerPushAddress + ":" + ServerPushPort);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
