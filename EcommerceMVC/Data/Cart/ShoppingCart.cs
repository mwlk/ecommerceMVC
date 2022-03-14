using EcommerceMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Cart
{
    public class ShoppingCart
    {
        public AppDbContext _context { get; set; }

        public string ShoppingCartId { get; set; }
        public List<CartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId
            };
        }

        public async Task AddItemToCart(Movie item)
        {
            var cartItem = _context.ShoppingCartItems.FirstOrDefault(i => i.Movie.Id == item.Id
                                                                     && i.ShoppingCartId == ShoppingCartId);

            if (cartItem == null)
            {
                cartItem = new CartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Movie = item,
                    Amount = 1
                };

                await _context.ShoppingCartItems.AddAsync(cartItem);
            }
            else
            {
                cartItem.Amount++;
            }

            await _context.SaveChangesAsync();
        }

        public async Task RemoveItemToCart(Movie item)
        {
            var cartItem = _context.ShoppingCartItems.FirstOrDefault(i => i.Movie.Id == item.Id
                                                                    && i.ShoppingCartId == ShoppingCartId);


            if (cartItem != null)
            {
                if (cartItem.Amount > 1)
                {
                    cartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(cartItem);
                }
            }

            await _context.SaveChangesAsync();
        }

        public List<CartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Movie)
                .ToList());
        }

        public double GetShoppingCartTotal() => _context.ShoppingCartItems.Where(i => i.ShoppingCartId == ShoppingCartId)
                        .Select(i => i.Movie.Price * i.Amount).Sum();

        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.ShoppingCartItems.Where(i => i.ShoppingCartId == ShoppingCartId).ToListAsync();

            _context.ShoppingCartItems.RemoveRange(items);

            await _context.SaveChangesAsync();
        }

    }
}
