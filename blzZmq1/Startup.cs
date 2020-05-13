using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using blzZmq1.Services;
using blzZmq1.Services.ChartData;
using Application;
using Application.Convertor;
using Application.MonicaCharts;
using blzZmq1.Services.MonicaCharts;

namespace blzZmq1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IFileUpload, FileUpload>();
            services.AddSingleton<Services.AppData>();  //for clientside App -  for serverside app use: services.AddScoped<Services.AppData>();
            services.AddSingleton<Services.ZmqProducer>();
            services.AddSingleton<Services.ZmqConsumer>();
            services.AddTransient<IMonicaZmqService, MonicaZmqService>();

            // My Services
            services.AddTransient<IDailyChartService, DailyChartService>();
            services.AddTransient<IMonicaJsonMapper, MonicaJsonMapper>();
            services.AddTransient<IMonicaChartApp, MonicaChartApp>();
            services.AddTransient<IMonicaChartService, MonicaChartService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
