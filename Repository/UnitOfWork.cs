using Appliance.Data;
using Appliance.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Appliance.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplianceDbContext _context;

        public UnitOfWork(ApplianceDbContext context)
        {
            _context = context;
           Products = new ProductRepository(_context);
            Orders = new OrderRepository(_context);
        }

        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
