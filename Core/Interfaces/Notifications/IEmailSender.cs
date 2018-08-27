using System.Threading.Tasks;

namespace Core.Interfaces.Notifications
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
