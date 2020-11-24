using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TestingASP4Rasp_V1._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(Setupconfig)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void Setupconfig(HostBuilderContext ctx, IConfigurationBuilder builder)
        {
            builder.Sources.Clear(); //remove default config options

            builder.AddJsonFile("config.json", false, true)
                //.AddXmlFile("config.xml", true)
                .AddEnvironmentVariables();
        }
    }
}
