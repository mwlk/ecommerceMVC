using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> Detail(int id)
        {
            var cinema = await _service.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            return View(cinema);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var cinema = await _service.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            return View(cinema);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo, Name, Description")] Cinema model)
        {
            if (!ModelState.IsValid) return View(model);

            await _service.UpdateAsync(id,model);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var cinema = await _service.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            return View(cinema);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var cinema = await _service.GetByIdAsync(id);

            if (cinema == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
