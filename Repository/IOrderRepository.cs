using Appliance.Models;
using Appliance.Repository.IRepository;

namespace Appliance.Repository
{
    public interface IOrderRepository:IRepository<Order>
    {
        IEnumerable<Order> GetOrdersByUser(int orderId);
    }
}
