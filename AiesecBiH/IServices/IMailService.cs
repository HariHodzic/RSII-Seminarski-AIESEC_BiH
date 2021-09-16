using AiesecBiH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.IServices
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        Task SendRegistrationConfirmaiton(string username, string password, string firstName, string lastName, string ToEmail);
    }
}
