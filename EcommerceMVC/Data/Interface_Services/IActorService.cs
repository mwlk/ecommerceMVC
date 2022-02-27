using EcommerceMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);

        Actor UpdateAsync(int id, Actor model);

        bool DeleteAsync(int id);
    }
}
