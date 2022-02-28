using EcommerceMVC.Data;
using EcommerceMVC.Data.Services;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Profile, FullName, Bio")] Actor model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _service.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            var detail = await _service.GetByIdAsync(id);

            if(detail == null) return View("NotFound");

            return View(detail);
            
        }

        public async Task<IActionResult> Edit(int id)
        {
            var detail = await _service.GetByIdAsync(id);

            if (detail == null) return View("NotFound");

            return View(detail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Profile, FullName, Bio")] Actor model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _service.UpdateAsync(id, model);

            return RedirectToAction(nameof(Index));
        }

    }
}
