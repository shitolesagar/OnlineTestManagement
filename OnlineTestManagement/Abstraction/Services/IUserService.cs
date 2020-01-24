using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Services
{
    public interface IUserService
    {
        ApplicationUserViewModel LoginAdmin(string email);
    }
}
