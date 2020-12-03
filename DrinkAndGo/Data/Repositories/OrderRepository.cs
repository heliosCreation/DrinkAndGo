using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public async Task CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            await _appDbContext.SaveChangesAsync();


            var shoppingItems = await _shoppingCart.GetShoppingCartItems();

            foreach (var item in shoppingItems)
            {
                var orderDetail = new OrderDetail()
                {
                    DrinkId = item.Drink.Id,
                    Amount = item.Amount,
                    Price = item.Drink.Price,
                    OrderId = order.Id,
                };

                 _appDbContext.OrderDetails.Add(orderDetail);
            }
            await _appDbContext.SaveChangesAsync();

        }
    }
}
