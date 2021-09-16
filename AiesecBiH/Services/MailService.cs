using AiesecBiH.IServices;
using AiesecBiH.Model;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Microsoft.Extensions.Options;
using AiesecBiH.Settings;
using System;

namespace AiesecBiH.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            try
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
                email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
                email.Subject = mailRequest.Subject;
                var builder = new BodyBuilder();
                builder.HtmlBody = mailRequest.Body;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
            catch(Exception ex){
                throw ex;
            }
        }

        public async Task SendRegistrationConfirmaiton(string username, string password, string firstName, string lastName, string toEmail)
        {
            MailRequest mailRequest = new MailRequest
            {
                Subject = "Welcome to AIESEC BiH",
                Body = "Hello " + firstName + " " + lastName +",<br /> We’re happy that another great person just joined our incredible community. These are your login credentials for mobile application:<br /> Username: " + username + "<br /> Password: " + password + "<br/> <br/>Sincirley,<br/>"+ System.Environment.NewLine + "AIESEC BiH",
                ToEmail = toEmail
            };
            await SendEmailAsync(mailRequest);
        }
    }
}
