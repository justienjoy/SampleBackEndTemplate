using SampleBackEndTemplate.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace SampleBackEndTemplate.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}