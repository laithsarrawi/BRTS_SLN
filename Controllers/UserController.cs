using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Claims;
using BRTS.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.CodeAnalysis.Scripting;
namespace BRTS.Web.Controllers
{
    public class UserController : Controller
    {

        [Route("")]
        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        public IActionResult SignUp()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult SignInRequest( Account Account)
        {
            ApplicationDBContext _dbContext = new ApplicationDBContext();

            var user = (from s in _dbContext.Account
                        where s.userName== Account.emailAddress  && s.password== Account.password  
                        select s ).FirstOrDefault() ;


            if (user.role == "Admin")
            {
                return RedirectToAction( "AdminDashBoard", "Admin");
            }
            else if (user.role == "Captin")
            {
                return RedirectToAction( "CaptinDashBoard", "Captin");
            }
            else if(user.role == "User")
            {
                return RedirectToAction("CustomerDashBoard", "Customer", new { id = user.accountId});
            }
            else
            {
                return RedirectToAction("SignIn", "User");
            }
        }

        [HttpPost]
        public IActionResult SignUpRequest(Account Acc)
        {
            ApplicationDBContext _dbContext = new ApplicationDBContext();
            
            _dbContext.Account.Add(Acc);
            _dbContext.SaveChanges();
            return SignIn();
        }

    }
}
