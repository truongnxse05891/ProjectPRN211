using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            var orderDetail = context.OrderDetails.ToList();

            TempData["orderDetails"] = JsonConvert.SerializeObject(orderDetail);
            TempData["orders"] = "";

            return View();
        }

        public IActionResult Add(string name, string address, int phone, List<string> orderIds)
        {
            var userId = HttpContext.Session.GetString("UserID");

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            List<Order> orders = context.Orders
                .Where(order => orderIds.Contains(order.OrderId.ToString())).ToList();

            foreach (var order in orders)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.AccountId = 2;
                orderDetail.RecipientName = name;
                orderDetail.RecipientAddress = address;
                orderDetail.RecipientPhone = phone;
                orderDetail.ProductId = order.ProductId;
                orderDetail.Quality = order.Quality;
                orderDetail.OrderDate = DateTime.Now;

                context.OrderDetails.Add(orderDetail);

                var orderToDelete = context.Orders
                .First(item => item.ProductId == order.ProductId && item.AccountId == order.AccountId);

                context.Remove(orderToDelete);
            }

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult GetDetail(List<string> orderIds)
        {
            var userId = HttpContext.Session.GetString("UserID");

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            TempData["orderDetails"] = "";

            List<Order> orders = context.Orders
                .Where(order => orderIds.Contains(order.OrderId.ToString())).ToList();

            TempData["orders"] = JsonConvert.SerializeObject(orders);

            return View("~/Views/OrderDetail/Index.cshtml");
        }
    }
}
