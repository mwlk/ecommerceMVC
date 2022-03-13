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

        public async Task AddNewMovieAsync(MovieViewModel model)
        {
            var newMovie = new Movie()
            {
                Title = model.Title,
                Description = model.Description,
                Price = model.Price,
                ImageURL = model.ImageURL,
                CinemaId = model.CinemaId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Category = model.Category,
                ProducerId = model.ProducerId
            };

            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            //Add Actors
            foreach (var actor in model.ActorsId)
            {
                var actorMovie = new Actor_Movie()
                {
                    MovieID = newMovie.Id,
                    ActorID = actor
                };

                await _context.Actors_Movies.AddAsync(actorMovie);
            }

            await _context.SaveChangesAsync();
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

        public async Task UpdateMovieAsync(MovieViewModel model)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == model.Id);

            if (movie != null)
            {

                movie.Title = model.Title;
                movie.Description = model.Description;
                movie.Price = model.Price;
                movie.ImageURL = model.ImageURL;
                movie.CinemaId = model.CinemaId;
                movie.StartDate = model.StartDate;
                movie.EndDate = model.EndDate;
                movie.Category = model.Category;
                movie.ProducerId = model.ProducerId;

                await _context.SaveChangesAsync();
            }

            var existingActors = await _context.Actors_Movies.Where(a => a.MovieID == model.Id).ToListAsync();
            _context.Actors_Movies.RemoveRange(existingActors);
            await _context.SaveChangesAsync();


            //Add Actors
            foreach (var actor in model.ActorsId)
            {
                var actorMovie = new Actor_Movie()
                {
                    MovieID = model.Id,
                    ActorID = actor
                };

                await _context.Actors_Movies.AddAsync(actorMovie);
            }

            await _context.SaveChangesAsync();
        }
    }
}
