using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        public async void AddItemToCart(Movie item)
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

                _context.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                cartItem.Amount++;
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



    }
}
