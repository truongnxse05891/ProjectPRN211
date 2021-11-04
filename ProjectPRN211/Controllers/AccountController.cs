using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Controllers
{
    public class AccountController : Controller
    {

        private  ProjectDemoContext context = new ProjectDemoContext();
        public IActionResult Index()
        {
            
                return View();
        }


        //GET: Register

        public IActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Account _account)
        {
            if (ModelState.IsValid)
            {
                var check = context.Accounts.FirstOrDefault(s => s.Email == _account.Email);
                if (check == null)
                {
                    _account.Password = GetMD5(_account.Password);
                    context.Accounts.Add(_account);
                    context.SaveChanges();
                    TempData["alertMessage"] = "Register successfully, please login!";
                    return RedirectToAction("Login","Account");
                }
                else
                {
                    TempData["alertMessage"] = "Email has been exist, please try another email";
                    return View();
                }


            }
            return View();


        }

        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var f_password = GetMD5(password);
                var data = context.Accounts.Where(s => s.Email.Equals(email) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    HttpContext.Session.SetString("FullName", JsonConvert.SerializeObject(data.FirstOrDefault().FullName));
                    HttpContext.Session.SetString("Email", JsonConvert.SerializeObject(data.FirstOrDefault().Email));
                    HttpContext.Session.SetString("UserID", JsonConvert.SerializeObject(data.FirstOrDefault().AccountId));
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    TempData["alertMessage"] = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        //Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();//remove session
            return RedirectToAction("Login");
        }



        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}
