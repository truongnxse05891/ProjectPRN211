using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectPRN211.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace ProjectPRN211.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectDemoContext context = new ProjectDemoContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int pageNo)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                var PAGE_SIZE = 5;

                var userName = JsonConvert.DeserializeObject(HttpContext.Session.GetString("FullName"));
                TempData["userName"] = userName;
                var userId = JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserID"));
                TempData["userId"] = userId;

                TempData["products"] = context.Products
                    .Skip(pageNo * PAGE_SIZE)
                    .Take(PAGE_SIZE)
                    .ToList();

                var pageCount = (int)Math.Ceiling(context.Products.Count() / (double)PAGE_SIZE);
                TempData["pageCount"] = pageCount;
                TempData["pageNo"] = pageNo;

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
