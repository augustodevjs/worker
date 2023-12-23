namespace WorkerService.Application.Interfaces
{
    public interface IEmail
    {
        void SendEmail(string to, string subject, string body);
    }
}
