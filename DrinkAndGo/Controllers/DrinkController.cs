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
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }

        [Route("List/{category?}", Name = "GetDrinks")]
        public ViewResult List(string category)
        {
            DrinkListViewModel vm = new DrinkListViewModel();

            if (string.IsNullOrEmpty(category))
            {
                vm.Drinks = _drinkRepository.Drinks;
                vm.Category = "All Drinks";
            }
            else
            {
                if (string.Equals("Alcoholic",category,StringComparison.OrdinalIgnoreCase))
                {
                    vm.Drinks = _drinkRepository.Drinks.Where(drink => drink.CategoryId == 1);
                }
                else
                {
                    vm.Drinks = _drinkRepository.Drinks.Where(drink => drink.CategoryId == 2);
                }
                vm.Category = category;

            }
            return View(vm);

        }
    }
}
