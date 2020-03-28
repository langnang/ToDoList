﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            var uuid = HttpContext.Session.GetString("uuid");
            if (string.IsNullOrEmpty(uuid))
            {
                return Redirect("/");
            }
            return View();
        }
    }
}
