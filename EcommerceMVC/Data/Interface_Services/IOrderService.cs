using EcommerceMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Interface_Services
{
    public interface IOrderService
    {
        Task StoreOrderAsync(List<CartItem> items, string userId, string userEmail);

        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
