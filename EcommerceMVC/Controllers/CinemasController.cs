using EcommerceMVC.Data;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] Cinema model)
        {
            if (!ModelState.IsValid) return View(model);

            await _service.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
