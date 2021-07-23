using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        [HttpPost("User/SubmitAddUserForm")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost("/User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.error = "Passwords Must Match";
            ViewBag.date = newUser.DateJoined;

            if (newUser.Password == verify)
            {
                UserData.Add(newUser);
                return View("Index");
            }
            return View("Add");
        }  

    }
}
