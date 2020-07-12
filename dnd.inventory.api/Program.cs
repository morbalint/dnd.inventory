using Autofac.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Serilog;

namespace dnd.inventory.api
{
    public sealed class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureLogging((context, logging) =>
                {
                    logging.ClearProviders();

                    /*
                     * You can use a global logger as this, but I don't recommend this way
                     * More information: https://github.com/drwatson1/AspNet-Core-REST-Service/wiki#logging
                    Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(context.Configuration)
                        .CreateLogger();
                    */

                    logging.AddSerilog(new LoggerConfiguration()
                        .ReadFrom.Configuration(context.Configuration)
                        .CreateLogger());
                })
                .ConfigureAppConfiguration(x => x.AddEnvironmentVariables())
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}
