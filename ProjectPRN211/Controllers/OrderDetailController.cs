using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPRN211.Controllers
{
    public class OrderDetailController : Controller
    {

        private ProjectDemoContext context = new ProjectDemoContext();
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetString("UserID");

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            TempData["userId"] = userId;

            return View();
        }
    }
}
