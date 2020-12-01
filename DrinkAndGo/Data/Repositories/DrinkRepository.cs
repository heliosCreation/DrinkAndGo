using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDb;

        public DrinkRepository(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public IEnumerable<Drink> Drinks => _appDb.Drinks;

        public IEnumerable<Drink> PreferredDrinks => _appDb.Drinks.Where(p => p.IsPreferredDrink);

        public Drink GetDrinkById(int drinkId) => _appDb.Drinks.Where(x => x.Id == drinkId).FirstOrDefault();
    
    }
}
