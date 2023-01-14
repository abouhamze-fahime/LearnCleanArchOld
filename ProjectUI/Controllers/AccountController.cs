using ApplicationCore.Interfaces;
using ApplicationCore.Security;
using ApplicationCore.ViewModels;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        public IActionResult Register(RegisterViewModels registerModel )
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

           CheckUser checkUser = _userService.CheckUser(registerModel.Email, registerModel.Mobile);
            if (checkUser!=CheckUser.Ok)
            {
                ViewBag.Check = checkUser;
                return View(registerModel);
            }

            User user = new User() 
            {
                Email=registerModel.Email.Trim().ToLower() , 
                UserName=registerModel.UserName , 
                Mobile = registerModel.Mobile , 
                Password = PasswordHelper.EncodePasswordMd5(registerModel.Password)
            };
            _userService.RegisterUser(user);


            return View("SuccessRegister", registerModel);
        }

    }
}
