using EcommerceMVC.Data.Cart;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class OrdersController1 : Controller
    {
        private readonly IMovieService _service;
        private readonly ShoppingCart _cart;

        public OrdersController1(IMovieService service, ShoppingCart cart)
        {
            _service = service;
            _cart = cart;
        }

        public IActionResult Index()
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
    }
}
