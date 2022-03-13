using EcommerceMVC.Data;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Controllers
{
    public class MoviesController : Controller
    {

        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _service.GetAllAsync(m => m.Cinema);

            return View(movies);
        }

        public async Task<IActionResult> Search(string searchString)
        {
            var movies = await _service.GetAllAsync(m => m.Cinema);

            if(!string.IsNullOrEmpty(searchString))
            {
                var filtered = movies.Where(m => m.Title.Contains(searchString) || m.Description.Contains(searchString))
                    .ToList();

                return View("Index", filtered);
            }

            return View("Index", movies);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var detail = await _service.GetMovieById(id);

            return View(detail);
        }

        public async Task<IActionResult> Create()
        {

            var dropdownsData = await _service.GetDropdownValues();

            ViewBag.Cinemas = new SelectList(dropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(dropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var dropdownsData = await _service.GetDropdownValues();

                ViewBag.Cinemas = new SelectList(dropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(dropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");

                return View(model);
            }

            await _service.AddNewMovieAsync(model);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var detail = await _service.GetMovieById(id);
            if (detail == null) return View("NotFound");

            var response = new MovieViewModel()
            {
                Id = detail.Id,
                Title = detail.Title,
                Description = detail.Description,
                Price = detail.Price,
                StartDate = detail.StartDate,
                EndDate = detail.EndDate,
                ImageURL = detail.ImageURL,
                Category = detail.Category,
                CinemaId = detail.CinemaId,
                ProducerId = detail.ProducerId,
                ActorsId = detail.Actors_Movies.Select(a => a.ActorID).ToList()
            };

            var dropdownsData = await _service.GetDropdownValues();

            ViewBag.Cinemas = new SelectList(dropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(dropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MovieViewModel model)
        {
            if (id != model.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var dropdownsData = await _service.GetDropdownValues();

                ViewBag.Cinemas = new SelectList(dropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(dropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(dropdownsData.Actors, "Id", "FullName");

                return View(model);
            }

            await _service.UpdateMovieAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
