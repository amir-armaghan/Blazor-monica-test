using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<Radzen.NotificationService>();

            // Added on 13:30 18.05.2020
            builder.Services.AddScoped<Services.IFileUpload, Services.FileUpload>();
            builder.Services.AddSingleton<Services.AppData>();  
            builder.Services.AddSingleton<Services.ZmqProducer>();
            builder.Services.AddSingleton<Services.ZmqConsumer>();
            builder.Services.AddTransient<Services.IMonicaZmqService, Services.MonicaParameters>();

            // My Services
            //builder.Services.AddTransient<Services.IMonicaJsonMapperService>
           //builder.Services.AddSingleton<Services.IMonicaJsonMapperService, MonicaJsonMapperService>();
           // builder.Services.AddTransient<IMonicaChartAppService, MonicaChartAppService>();
           // builder.Services.AddTransient<IMonicaChartService, MonicaChartService>();

            await builder.Build().RunAsync();
        }
    }
}
