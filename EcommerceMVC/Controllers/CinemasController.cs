using EcommerceMVC.Data;
using EcommerceMVC.Data.Interface_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EcommerceMVC.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service;

        public CinemasController(ICinemaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var cinemas = await _service.GetAllAsync();

            return View(cinemas);
        }
    }
}
