using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OnlineTestManagement.Services
{
    public class EmailService : IEmailService
    {
        private readonly ISmtpMailRepository smtpMailRepository;

        public EmailService(ISmtpMailRepository smtpMailRepository)
        {
            this.smtpMailRepository = smtpMailRepository;
        }

        public Task SendEmail(string to, string body, string subject, bool doAddAdminToCC = false)
        {
            var smtpInfo = smtpMailRepository.GetMailInfo();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(smtpInfo.Host);
            mail.From = new MailAddress(smtpInfo.FromMail, smtpInfo.DisplayName);
            if (doAddAdminToCC)
            {
                mail.CC.Add(MessageConstants.AdminMail);
            }
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SmtpServer.Port = int.Parse(smtpInfo.Port);
            SmtpServer.Credentials = new System.Net.NetworkCredential(smtpInfo.FromMail, smtpInfo.SmtpPassword);
            SmtpServer.EnableSsl = true;
            return SmtpServer.SendMailAsync(mail);
        }
    }
}
