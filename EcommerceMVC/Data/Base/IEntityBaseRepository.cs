using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceMVC.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class, IEntityBase, new ()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task AddAsync(T model);

        Task UpdateAsync(int id, T model);

        Task DeleteAsync(int id);
    }
}
