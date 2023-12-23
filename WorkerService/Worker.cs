using WorkerService.Application.Interfaces;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly IEmail _email;
        private readonly ILogger<Worker> _logger;
        private readonly IHttpService _httpService;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public Worker(IEmail email, ILogger<Worker> logger, IHttpService httpService, IHostApplicationLifetime hostApplicationLifetime)
        {
            _email = email;
            _logger = logger;
            _httpService = httpService;
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                var statusSite = await _httpService.ChecksStatusSite("http://localhost:3000");

                if(statusSite != System.Net.HttpStatusCode.OK)
                {
                    _email.SendEmail("emaildestinatario@gmail.com", "Worker Service Test", $"Site not running at {DateTimeOffset.Now}");
                    _hostApplicationLifetime.StopApplication();
                }

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}