using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.Services
{
    public class UserService : IUserService
    {
        private IApplicationUserRepository _applicationUserRepository;

        public UserService(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public ApplicationUserViewModel LoginAdmin(string email)
        {
            var user = _applicationUserRepository.FindByEmail(email);
            return user;
        }
    }
}
