using EcommerceMVC.Data.Base;
using EcommerceMVC.Models;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Interface_Services
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieById(int id);
    }
}
