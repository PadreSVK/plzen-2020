using System;
using System.Threading.Tasks;
using GenericHostSample.Services;
using GenericHostSample.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GenericHostSample
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            //https://github.com/aspnet/Extensions/blob/494e2c53cd/src/Hosting/Abstractions/src/HostingAbstractionsHostExtensions.cs
            await CreateHostBuilder(args)
                .Build()
                .RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            //https://github.com/aspnet/Extensions/blob/609c3910d932284efd8f8950aeec46e3d2149d9a/src/Hosting/Hosting/src/Host.cs#L56
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var configurationSection = hostContext.Configuration.GetSection("TestVariable").Value;

                    var value = hostContext.Configuration.GetSection("ComplexObject:First").Value;
                    var complexSettingsValue = hostContext.Configuration.GetSection("ComplexObject:Third").Value;
                    services.Configure<ComplexSettings>(hostContext.Configuration.GetSection("ComplexObject"));
                    
                    //
                    //services.AddOptions<ComplexSettings>()
                    //    .Bind(hostContext.Configuration.GetSection("ComplexObject"))
                    //    .ValidateDataAnnotations();

                    //services.AddOptions<ComplexSettings>()
                    //    .Bind(hostContext.Configuration.GetSection("ComplexObject"))
                    //    .Validate(o=> o.Third > 500);

                    var secretValue = hostContext.Configuration.GetSection("asdasdadasd").Value;
                    services.AddHostedService<CustomHostedService>();
                    services.AddSingleton<IMyService, MyService>();
                    services.AddHttpClient();
                })
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.AddUserSecrets<Program>();
                })
        ;
    }
}