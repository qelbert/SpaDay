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

            return SubmitAddUserForm(new User(Username, Email, Password1), Verify);
        }

        public IActionResult Add()
        {

            return View();
        }

        public IActionResult SubmitAddUserForm(User newUser, string Verify)
        {
            if (Verify == newUser.Password)
            {
                ViewBag.name = newUser.Username;
                return View("Index");
            } else
            {
                ViewBag.name = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.error = "Hey, the passwords need to match!";
                return View("Add");
            }
        }
    }
}
