using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Services
{
    public interface IEmailService
    {
        Task SendEmail(string to, string body, string subject, bool doAddAdminToCC = false);
    }
}
