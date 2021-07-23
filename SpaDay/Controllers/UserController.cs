﻿using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
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

            if(newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return Redirect("/User/Index");
            }
            return Redirect("/User/Add");
        }  

    }
}
