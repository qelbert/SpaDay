using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string Username, string Email, string Password1, string Verify)
        {

            ViewBag.name = Username;
            return SubmitAddUserForm(new User(Username, Email, Password1), Verify);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SubmitAddUserForm(User newUser, string Verify)
        {
            // add form submission handling code here
            if (Verify == newUser.Password)
            {
                ViewBag.pword = Verify;
                return View("Index");

            } else
            {
                return Redirect("/User/Add");
            } 
        }
    }
}
