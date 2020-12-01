using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            _drinkRepository = drinkRepository;
            _shoppingCart = shoppingCart;
        }


        public async Task<ViewResult> Index()
        {
            _shoppingCart.ShoppingCartItems = await _shoppingCart.GetAllShoppingCartItems();
            var cartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                TotalPrice = _shoppingCart.getCartPrice()
            };

            return View(cartViewModel);
        }

        public async Task<ActionResult> AddToCart(int drinkId)
        {
            var drink = _drinkRepository.Drinks.FirstOrDefault(drink => drink.Id == drinkId);
            if (drink != null)
            {
                await _shoppingCart.AddToCart(drink, 1);
            }
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> RemoveFromCart(int drinkId)
        {
            var drink = _drinkRepository.Drinks.FirstOrDefault(drink => drink.Id == drinkId);
            if (drink != null)
            {
                await _shoppingCart.RemoveFromCart(drink);
            }
            return RedirectToAction("Index");
        }


    }
}
