using Appliance.Models;
using Appliance.Repository.IRepository;

namespace Appliance.Repository
{
    public interface IProductRepository:IRepository<Product>
    {
        IEnumerable<Product> GetProductsByCategory(string category);
    }
}
