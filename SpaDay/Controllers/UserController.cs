﻿using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using SpaDay.ViewModels;
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
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }
        [HttpPost("/User/Add")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password,
                    Email = addUserViewModel.Email
                };
                UserData.Add(newUser);
                return View("Index", newUser);
            }

            return View("Add", addUserViewModel);
        }

    }
}
