using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = await _shoppingCart.GetShoppingCartItems();
            if (_shoppingCart.ShoppingCartItems.Count > 1)
            {
                ModelState.AddModelError("", "It seems like your cart is empty, please choose some drinks first.");
            }

            if (ModelState.IsValid)
            {
                await _orderRepository.CreateOrder(order);
                await _shoppingCart.clearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            return View();
        }
    }
}
