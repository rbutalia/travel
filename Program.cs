
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;


namespace travel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseKestrel()
                   .UseConfiguration(new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                               .AddJsonFile("hosting.json", optional: false)
                                                               .Build())
                   .Build();
    }
}
