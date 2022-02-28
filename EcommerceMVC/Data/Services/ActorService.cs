using EcommerceMVC.Data.Base;
using EcommerceMVC.Models;

namespace EcommerceMVC.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        public ActorService(AppDbContext context) : base(context) { }

    }
}
