using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class AccountController : Controller


    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;

        public IdentityResult IdentityResult { get; private set; }

        public AccountController(UserManager<IdentityUser> userMngr, SignInManager<IdentityUser> signInMngr)
        {
            userManager = userMngr;
            signInManager = signInMngr;
        }

        public IActionResult Register()
        {
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> AddUser(RegisterViewModel registerViewModel) {

            if (ModelState.IsValid)
            {
                ApplicationUsers applicationUser = new ApplicationUsers()
                {

                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email,
                    PhoneNumber = registerViewModel.PhoneNumber,


                };

                IdentityResult identityResult = await userManager.CreateAsync(applicationUser, registerViewModel.Password);


                if (identityResult.Succeeded) {

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach(var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View("Register", registerViewModel);
                }


            }
            else
            {
                return View("Register", registerViewModel);
            }

        }


        public IActionResult Login(string? ReturnUrl)


        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginUser(LoginViewModel loginViewModel,string? ReturnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var Result = await signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, false);

                if (Result.Succeeded)
                {
                    if (ReturnUrl == null)
                    {
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        return LocalRedirect(ReturnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user Credentials");
                    return View("Login", loginViewModel);
                }
            }
            else
            {
                return View("Login", loginViewModel);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignOutUser()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
