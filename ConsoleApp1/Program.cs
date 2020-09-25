using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConsoleApp1
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await CreateHostBuilder(args)
                .Build()
                .RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder()
                    .ConfigureServices((hostBuilderContext, serviceCollection) =>
                    {

                        var value = hostBuilderContext.Configuration.GetSection("TestVariable").Value;
                        //serviceCollection.Configure<MySuperSettings>(hostBuilderContext.Configuration.GetSection(nameof(MySuperSettings)));

                        serviceCollection.AddOptions<MySuperSettings>()
                            .Bind(hostBuilderContext.Configuration.GetSection(nameof(MySuperSettings)))
                            .ValidateDataAnnotations();

                        serviceCollection.AddHostedService<MyHostedService>();
                        //if (value is null)
                        //{
                        //    serviceCollection.AddSingleton<ISuperInterface, NewImplementation>();
                        //}
                        //else
                        //{
                        //    serviceCollection.AddSingleton<ISuperInterface, MyPerfectClass>();

                        //}
                        serviceCollection.AddTransient<MyPerfectClass>();
                        serviceCollection.AddSingleton<ISuperInterface2, MyPerfectTestClass>();
                        serviceCollection.AddHttpClient();
                    })
                    .ConfigureAppConfiguration(builder =>
                    {
                        builder.AddUserSecrets<Program>();
                    })
                ;
        }
    }


    public interface ISuperInterface2
    {
        int GetAge();
    }


    public class MyPerfectClass : ISuperInterface
    {
        public MyPerfectClass()
        {
            
        }
        public string GetName() => "Patrik";
    }
   
    class MyPerfectTestClass : ISuperInterface2
    {
        private readonly ISuperInterface superInterface;

        public MyPerfectTestClass(MyPerfectClass superInterface)
        {
            this.superInterface = superInterface;
        }

        public int GetAge() => 5000;
    }

    public class MyHostedService : IHostedService
    {
        private readonly ILogger<MyHostedService> logger;
        private readonly ISuperInterface superInterface;
        private readonly ISuperInterface2 superInterface2;
        private readonly HttpClient httpClient;
        private readonly MySuperSettings options;

        public MyHostedService(ILogger<MyHostedService> logger, 
            MyPerfectClass superInterface, 
            ISuperInterface2 superInterface2, 
            IOptions<MySuperSettings> options, 
            IHttpClientFactory httpClientFactory)
        {
            this.logger = logger;
            this.superInterface = superInterface;
            this.superInterface2 = superInterface2;

            this.httpClient = httpClientFactory.CreateClient();
            this.options = options.Value;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(1000);
                var httpResponseMessage = await httpClient.GetAsync("asdadasd", cancellationToken);
                var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();

                logger.LogWarning("ahoj sad asd asd as");
            }
            Console.WriteLine($"MySuper {nameof(MyHostedService)} start");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"MySuper {nameof(MyHostedService)} stop");
            return Task.CompletedTask;
        }
    }
}