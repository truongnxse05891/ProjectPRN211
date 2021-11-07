using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPRN211.Controllers
{
    public class OrderController : Controller
    {

        private ProjectDemoContext context = new ProjectDemoContext();
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetString("UserID");

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var orders = new List<Order>();

            context.Orders.Join(
                context.Products,
                order => order.ProductId,
                product => product.ProductId,
                (order, product) => new { order, product })
                .ToList()
                .ForEach(v =>
                {
                    v.order.OrderProduct = v.product;
                    orders.Add(v.order);
                });

            TempData["orders"] = orders;
            TempData["userId"] = userId;

            return View();
        }


        // GET: Edit

        public IActionResult Edit(Order _order)
        {
            var existingOrder = context.Orders
                .First(item => item.ProductId == _order.ProductId && item.AccountId == _order.AccountId);
            existingOrder.OrderDate = DateTime.Now;
            existingOrder.Quality = _order.Quality;

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        //POST: Delete

        public IActionResult Delete(Order _order)
        {
            var order = context.Orders
                .First(item => item.ProductId == _order.ProductId && item.AccountId == _order.AccountId);

            context.Remove(order);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order _order)
        {
            var existingOrder = context.Orders
                .FirstOrDefault(item => item.ProductId == _order.ProductId && item.AccountId == _order.AccountId);

            if (existingOrder == null)
            {
                _order.OrderDate = DateTime.Now;
                context.Orders.Add(_order);
            }
            else
            {
                existingOrder.Quality += _order.Quality;
                existingOrder.OrderDate = DateTime.Now;
            }

            context.SaveChanges();

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
