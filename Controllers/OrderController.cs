using Appliance.Models;
using Appliance.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Appliance.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult MyOrders(int orderId)
        {
            var orders = _unitOfWork.Orders.GetOrdersByUser(orderId);
            return View(orders);
        }

        public IActionResult PlaceOrder(Order order)
        {
            _unitOfWork.Orders.Add(order);
            _unitOfWork.Complete();

            return RedirectToAction("MyOrders", new { userId = order.OrderId });
        }
    }
}
