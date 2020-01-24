using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Abstraction.Repository
{
    public interface IApplicationUserRepository
    {
        ApplicationUserViewModel FindByEmail(string Email);
        void Add(ApplicationUserViewModel model);
    }
}
