using System.Net;
using WorkerService.Application.Interfaces;

namespace WorkerService.Application.Services
{
    public class HttpService : IHttpService
    {
        public async Task<HttpStatusCode> ChecksStatusSite(string url)
        {
            var client = new HttpClient();

            try
            {
                var response = await client.GetAsync(url);
                return response.StatusCode;
            } 
            catch (HttpRequestException ex)
            {
                return HttpStatusCode.NotFound;
            } 
            finally 
            { 
                client.Dispose(); 
            }
        }
    }
}
