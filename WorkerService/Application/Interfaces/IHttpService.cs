using System.Net;

namespace WorkerService.Application.Interfaces
{
    public interface IHttpService
    {
        Task<HttpStatusCode> ChecksStatusSite(string url);
    }
}
