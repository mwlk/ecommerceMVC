using EcommerceMVC.Data.Base;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;

namespace EcommerceMVC.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(AppDbContext context) : base(context)
        {
        }
    }
}
