using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTestManagement.Abstraction.Repository;
using OnlineTestManagement.Entities.ViewModels;

namespace OnlineTestManagement.Controllers
{
    public class DignosisController : Controller
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public DignosisController(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }

        [AllowAnonymous]
        public IActionResult RegisterAdmin()
        {
            var user = _applicationUserRepository.FindByEmail("admin@gmail.com");
            if (user.EmailId == null)
            {
                ApplicationUserViewModel AdminUser = new ApplicationUserViewModel()
                {
                    Name = "Admin",
                    EmailId = "test@gmail.com",
                    //CreatedDateTime = DateTime.Now,
                    MobileNumber = "9423237999",
                    RoleId = 1
                };
                using (var hmac = new System.Security.Cryptography.HMACSHA512())
                {
                    AdminUser.PasswordSalt = hmac.Key;
                    AdminUser.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("Reset1234"));
                }
                _applicationUserRepository.Add(AdminUser);
            }
            return RedirectToAction("Index", "Account");
        }
    }
}