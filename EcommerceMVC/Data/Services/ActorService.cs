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

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);

            await _context.SaveChangesAsync();
        }

        public bool DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();

            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(x => x.ActorId == id);

            return result;
        }

        public Actor UpdateAsync(int id, Actor model)
        {
            throw new System.NotImplementedException();
        }
    }
}
