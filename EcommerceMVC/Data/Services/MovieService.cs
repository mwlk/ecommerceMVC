using EcommerceMVC.Data.Base;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;

namespace EcommerceMVC.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        public MovieService(AppDbContext context) : base(context)
        {
        }
    }
}
