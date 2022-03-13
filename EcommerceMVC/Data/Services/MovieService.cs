using EcommerceMVC.Data.Base;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Data.ViewModels;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<MovieDropdownsViewModel> GetDropdownValues()
        {
            var response = new MovieDropdownsViewModel()
            {
                Actors = await _context.Actors.OrderBy(a => a.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(c => c.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(p => p.FullName).ToListAsync(),
            };

            return response;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            var detail = await _context.Movies
                                              .Include(c => c.Cinema)
                                              .Include(p => p.Producer)
                                              .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                                              .FirstOrDefaultAsync(m => m.Id == id);

            return detail;
        }
    }
}
