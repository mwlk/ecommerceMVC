using EcommerceMVC.Data.Base;
using EcommerceMVC.Data.Interface_Services;
using EcommerceMVC.Models;

namespace EcommerceMVC.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>, IProducerService
    {
        public ProducerService(AppDbContext context) : base(context)
        {
        }
    }
}
