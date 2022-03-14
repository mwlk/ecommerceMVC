using EcommerceMVC.Data.Cart;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EcommerceMVC.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMovieService _service;
        private readonly ShoppingCart _cart;
        private readonly IOrderService _order;

        public OrdersController(IMovieService service, ShoppingCart cart, IOrderService order)
        {
            _service = service;
            _cart = cart;
            _order = order;
        }

        public IActionResult ShoppingCart()
        {
            var items = _cart.GetShoppingCartItems();

            _cart.ShoppingCartItems = items;

            var response = new ShoppingCartViewModel()
            {
                Shopping = _cart,
                CartTotal = _cart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<IActionResult> AddToShoppingCart(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);

            if (movie != null)
            {
                await _cart.AddItemToCart(movie);
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveToShoppingCart(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);

            if (movie != null)
            {
                await _cart.RemoveItemToCart(movie);
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _cart.GetShoppingCartItems();
            string userId = "";
            string userEmail = "";

            await _order.StoreOrderAsync(items, userId, userEmail);

            await _cart.ClearShoppingCartAsync();

            return View("OrderCompleted");
        }
    }
}
