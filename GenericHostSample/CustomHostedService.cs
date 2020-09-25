using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GenericHostSample.Services;
using GenericHostSample.Settings;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GenericHostSample
{
    public class CustomHostedService : IHostedService
    {
        private readonly ILogger<CustomHostedService> logger;
        private readonly IMyService myService;
        private readonly ComplexSettings complexSettings;
        private readonly HttpClient httpClient;

        public CustomHostedService(ILogger<CustomHostedService> logger, IMyService myService, IHttpClientFactory httpClientFactory, IOptions<ComplexSettings>  complexSettings)
        {
            this.logger = logger;
            this.myService = myService;
            this.complexSettings = complexSettings.Value;
            this.httpClient = httpClientFactory.CreateClient();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Custom hosted service started");
            //https://beeceptor.com/console/plzen-2020
            var httpResponseMessage = await httpClient.GetAsync("https://plzen-2020.free.beeceptor.com/my/api/path", cancellationToken);
            var responseMessage = await httpResponseMessage.Content.ReadAsStringAsync();
            logger.LogInformation(responseMessage);
            logger.LogInformation(myService.CreateName());
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Custom hosted service stopped");
            return Task.CompletedTask;
        }
    }
}