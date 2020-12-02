using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Component
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            _shoppingCart.ShoppingCartItems = await _shoppingCart.GetAllShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                TotalPrice = _shoppingCart.getCartPrice()
            };

            return View(shoppingCartViewModel);
        }
    }
}
