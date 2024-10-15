using Appliance.Models;
using Microsoft.EntityFrameworkCore;

namespace Appliance.Repository
{
    public class ProductRepository:Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context): base(context) { }
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _context.Set<Product>().Where(p => p.Category == category).ToList();
        }
    }
}
