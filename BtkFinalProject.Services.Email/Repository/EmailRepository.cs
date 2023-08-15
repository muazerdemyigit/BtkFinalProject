using BtkFinalProject.Services.Email.DbContexts;
using BtkFinalProject.Services.Email.Messages;
using BtkFinalProject.Services.Email.Models;
using Microsoft.EntityFrameworkCore;

namespace BtkFinalProject.Services.Email.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> _dbContext;

        public EmailRepository(DbContextOptions<ApplicationDbContext> dbContext)
        {
            _dbContext = dbContext;
        }

        // public async Task SendAndLogEmail(UpdatePaymentResultMessage message)
        public void SendAndLogEmail(UpdatePaymentResultMessage message)
        {
            //implement an email sender or call some other class library
            EmailLog emailLog = new EmailLog()
            {
                Email = message.Email,
                EmailSent = DateTime.Now,
                Log = $"Order - {message.OrderId} has been created successfully."
            };

            //await using var _db = new ApplicationDbContext(_dbContext);
            //_db.EmailLogs.Add(emailLog);
            //await _db.SaveChangesAsync();
        }
    }
}
