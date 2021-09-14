using System.Threading.Tasks;
using EAP.Shared.SendEmail;

namespace EAP.Contracts.IRepositoty.EmailSernderRepo
{
    public interface IEmailSender
    {
        Task SendEmailAsync(Message message);
    }
}