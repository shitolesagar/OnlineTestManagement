﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTestManagement.Abstraction.Services;
using OnlineTestManagement.Constants;
using OnlineTestManagement.Entities.ViewModels;
using OnlineTestManagement.Models;

namespace OnlineTestManagement.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        #region Services
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Login
        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            try
            {
                ApplicationUserViewModel user = _userService.LoginAdmin(model.Email);
                if (user != null && model.Password == "Reset1234")
                {
                    //if (!VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
                    //{
                    //    ModelState.AddModelError("Password", MessageConstants.LoginError);
                    //    return View(model);
                    //}
                    if (user.RoleId == 1)
                    {
                        await SignInAsync(user);
                        TempData["Message"] = MessageConstants.LoginSuccessfull;
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("Password", MessageConstants.LoginError);
            }
            catch
            {

            }
            return View(model);
        }
        #endregion

        #region Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        #endregion

        #region Private Methods
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private async Task SignInAsync(ApplicationUserViewModel user)
        {
            var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Email, user.EmailId),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                    };
            var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(10),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }
        #endregion

        #region Error View
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}