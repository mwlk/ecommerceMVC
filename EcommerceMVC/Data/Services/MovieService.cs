using EcommerceMVC.Data.Base;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
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
