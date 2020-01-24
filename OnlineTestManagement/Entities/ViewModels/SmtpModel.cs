using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Entities.ViewModels
{
    public class SmtpModel
    {
        public int Id { get; set; }
        public string FromMail { get; set; }
        public string SmtpPassword { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
