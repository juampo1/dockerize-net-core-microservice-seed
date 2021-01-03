using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using ProductServiceHost.Configuration;
using System;
using System.IO;

namespace ProductServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var port = int.Parse(Environment.GetEnvironmentVariable("Port"));
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .UseUrls($"http://0.0.0.0:{port}")
                    .UseConfiguration(config)
                    .Build();

                host.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.ExitCode = -1;
            }
        }
    }
}
