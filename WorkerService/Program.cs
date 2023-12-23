using WorkerService.Application.Services;
using WorkerService.Application.Interfaces;

namespace WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>()
                    .AddSingleton<IEmail, Email>()
                    .AddSingleton<IHttpService, HttpService>();
                })
                .Build();

            host.Run();
        }
    }
}