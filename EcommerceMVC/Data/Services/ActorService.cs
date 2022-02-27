using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Services
{
    public class ActorService : IActorService
    {

        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);

            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();

            return result;
        }

        public Actor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Upddate(int id, Actor model)
        {
            throw new System.NotImplementedException();
        }
    }
}
