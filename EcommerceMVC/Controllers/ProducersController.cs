using EcommerceMVC.Data;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService _service;

        public ProducersController(IProducerService service) => _service = service;


        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var producer = await _service.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            return View(producer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Profile, FullName, Bio")] Producer model)
        {
            if (!ModelState.IsValid) return View(model);

            await _service.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var producer = await _service.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            return View(producer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Profile, FullName, Bio")] Producer model)
        {
            if (!ModelState.IsValid) return View(model);

            if (id == model.Id)
            {
                await _service.UpdateAsync(id, model);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var producer = await _service.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            return View(producer);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _service.GetByIdAsync(id);

            if (producer == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
