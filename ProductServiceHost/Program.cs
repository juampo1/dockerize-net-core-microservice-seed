using Microsoft.AspNetCore.Hosting;
using ProductServiceHost.Configuration;
using System;

namespace ProductServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var port = int.Parse(Environment.GetEnvironmentVariable("Port"));

                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseStartup<Startup>()
                    .UseUrls($"http://0.0.0.0:{port}")
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
