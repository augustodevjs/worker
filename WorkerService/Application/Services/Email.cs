using WorkerService.Helper;
using WorkerService.Application.Interfaces;

namespace WorkerService.Application.Services
{
    public class Email : IEmail
    {
        public void SendEmail(string to, string subject, string body)
        {
            var gmail = new EmailHelper("smtp.gmail.com", "seuemail@gmail.com", ENV.PASSWORD);
            gmail.SendEmail(new List<string> { to }, subject, body, new());
        }
    }
}
