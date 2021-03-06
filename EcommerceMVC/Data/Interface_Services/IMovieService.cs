using EcommerceMVC.Data.Base;
using EcommerceMVC.Data.ViewModels;
using EcommerceMVC.Models;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Interface_Services
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<MovieDropdownsViewModel> GetDropdownValues();
        Task AddNewMovieAsync(MovieViewModel model);
        Task UpdateMovieAsync(MovieViewModel model);
    }
}
