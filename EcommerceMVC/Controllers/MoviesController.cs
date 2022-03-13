using EcommerceMVC.Data;
using EcommerceMVC.Data.Interface_Services;
using Microsoft.AspNetCore.Mvc;
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
            //var movies = await _context.Movies
            //                    .Include(c => c.Cinema)
            //                    .OrderByDescending(m => m.StartDate).ThenByDescending(m => m.Price)
            //                    .ToListAsync();

            var movies = await _service.GetAllAsync(m => m.Cinema);

            return View(movies);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var detail = await _service.GetMovieById(id);

            return View(detail);
        }

        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to our system";
            ViewBag.Description = "Movies Shop";

            return View();
        }
    }
}
