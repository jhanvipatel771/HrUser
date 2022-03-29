using HrUser.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;

namespace HrUser.Controllers
{
    [Route("Login")]
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private UserManager<AppUser> userManager;
        //private SignInManager<AppUser> signInManager;

        //public HomeController(UserManager<AppUser> userMgr, SignInManager<AppUser> signinMgr)
        //{
        //    userManager = userMgr;
        //    signInManager = signinMgr;
        //}

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        [Route("Login")]
        [Route("~/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Execute your logic
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(model);
        }


        [AllowAnonymous,HttpGet]
        [Route("forgetpassword")]
        public IActionResult forgetpassword()
        {
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> ForgetPassword([Required] string Email)
        //{
        //    if (!ModelState.IsValid)
        //        return View(Email);

        //    var user = await userManager.FindByEmailAsync(Email);
        //    if (user == null)
        //        return RedirectToAction("ForgetpasswordConfirmation");

        //    var token = await userManager.GeneratePasswordResetTokenAsync(user);
        //    var link = Url.Action("ResetPassword", "Account", new { token, Email = user.Email }, Request.Scheme);

        //    EmailHelper emailHelper = new EmailHelper();
        //    bool emailResponse = emailHelper.SendEmailPasswordReset(user.Email, link);

        //    if (emailResponse)
        //        return RedirectToAction("ForgetpasswordConfirmation");
        //    else
        //    {
        //        // log email failed 
        //    }
        //    return View(Email);
        //}

        [AllowAnonymous]
        [Route("ForgetpasswordConfirmation")]
        public IActionResult ForgetpasswordComfirmation()
        {
            return View();
        }

        //[HttpPost][AllowAnonymous]
        //public async Task<IActionResult> forgetpassword(ForgetPassword model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByEmailAsync(model.Email);
        //        if (user != null && await _userManager.IsEmailConfirmedASYNC(User))
        //        {
        //            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //            var passwordResetLink = Url.Action("ResetPassword", "Home",
        //                new { email = model.Email, token = token }, Request.Scheme);

        //            _logger.Log(LogLevel.Warning, passwordResetLink);

        //           return View("ForgetpasswordConfirmation");
        //       }
        //        return View("ForgetpasswordConfirmation");
        //    }
        //    return View(model);
        //}

        //[AllowAnonymous, HttpGet]  
        //[Route("resetpassword")]
        //public IActionResult resetpassword(string token, string email)
        //{
        //    if (token == null || email == null)
        //    {
        //        ModelState.AddModelError("", "Invalid Password Reset Token");
        //    }
        //    return View();
        //}

        [AllowAnonymous]
        public IActionResult resetpassword(string token, string email)
        {
            var model = new ResetPassword { Token = token, Email = email };
            return View(model);
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> ResetPassword(ResetPassword resetPassword)
        //{
        //    if (!ModelState.IsValid)
        //        return View(resetPassword);

        //    var user = await userManager.FindByEmailAsync(resetPassword.Email);
        //    if (user == null)
        //        RedirectToAction("ResetPasswordConfirmation");

        //    var resetPassResult = await userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);
        //    if (!resetPassResult.Succeeded)
        //    {
        //        foreach (var error in resetPassResult.Errors)
        //            ModelState.AddModelError(error.Code, error.Description);
        //        return View();
        //    }

        //    return RedirectToAction("ResetPasswordConfirmation");
        //}

        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

    //[HttpPost]
    //[AllowAnonymous]
    //public async Task<IActionResult> resetpassword(ResetPassword model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var user = await _userManager.FindByEmailAsync(model.Email);
    //        if (user != null)
    //        {
    //            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
    //            if (result.Succeeded)
    //            {
    //                return View("ResetPasswordConfirmation");
    //            }
    //            foreach (var error in result.Errors)
    //            {
    //                ModelState.AddModelError("", error.Description);
    //            }
    //            return View(model);
    //        }
    //        return View("ResetPasswordConfirmation");
    //    }
    //    return View(model);
    //


    [Route("Dash")]
        public IActionResult Dash()
        {
            return View();
        }

        [Route("emailindex")]
        public IActionResult emailindex()
        {
            return View();
        }

        [Route("Compose")]
        public IActionResult Compose()
        {
            return View();
        }


        [Route("update")]
        public IActionResult update()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult update(UpdateView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Execute your logic
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(model);
        }

        [Route("EmployeeList")]
        public IActionResult EmployeeList()
        {
            return View();
        }

        [Route("Onboarding")]
        public IActionResult Onboarding()
        {
            return View();
        }

        [Route("profile")]
        public IActionResult profile()
        {
            return View();
        }

        [HttpGet]
        [Route("ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Execute your logic
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(model);
        }
    }
}
