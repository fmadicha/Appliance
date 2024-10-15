using Appliance.Models;
using Microsoft.EntityFrameworkCore;

namespace Appliance.Repository
{
    public class OrderRepository:Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context) { }

        public IEnumerable<Order> GetOrdersByUser(int orderId)
        {
            return _context.Set<Order>().Where(o => o.OrderId == orderId).ToList();
        }
    }
}
