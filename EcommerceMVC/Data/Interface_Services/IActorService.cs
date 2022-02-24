using EcommerceMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        Actor Upddate(int id, Actor model);

        bool Delete(int id);
    }
}
