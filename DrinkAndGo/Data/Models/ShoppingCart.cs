using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }



        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var dbContext = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(dbContext) { ShoppingCartId = cartId };

        }

        public async Task  AddToCart(Drink drink, int amount)
        {
            var shoppingCartItem = GetShoppingCartItem(drink);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Drink = drink,
                    Amount = 1
                };
               await _appDbContext.ShoppingCartItems.AddAsync(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++; 
            }

           await _appDbContext.SaveChangesAsync();
        }

        public async Task<int> RemoveFromCart(Drink drink)
        {
            var shoppingCartItem = GetShoppingCartItem(drink);
            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount>1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }

                else
                {
                     _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }

                await _appDbContext.SaveChangesAsync();
            }

            return localAmount;
        }

        public ShoppingCartItem GetShoppingCartItem(Drink drink)
        {
            return _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Drink.Id == drink.Id && s.ShoppingCartId == ShoppingCartId);
        }

        public async Task<List<ShoppingCartItem>> GetAllShoppingCartItems()
        {
            return ShoppingCartItems ??  (ShoppingCartItems = await _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).ToListAsync());
        }

        public async Task clearCart()
        {
            var shoppingCartItems = GetAllShoppingCartItems();
            _appDbContext.ShoppingCartItems.RemoveRange(ShoppingCartItems);

            await _appDbContext.SaveChangesAsync();
        }

        public decimal getCartPrice()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Drink.Price * c.Amount).Sum();
            return total;
        }


    }
}
