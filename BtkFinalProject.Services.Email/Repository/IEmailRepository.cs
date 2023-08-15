using BtkFinalProject.Services.Email.Messages;

namespace BtkFinalProject.Services.Email.Repository
{
    public interface IEmailRepository
    {
        //Task SendAndLogEmail(UpdatePaymentResultMessage message);
        void SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
