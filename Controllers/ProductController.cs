using Appliance.Models;
using Appliance.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Appliance.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var products = _unitOfWork.Products.GetAll();
            return View(products);
        }

        public IActionResult AppliancesByCategory(string category)
        {
            var appliances = _unitOfWork.Products.GetProductsByCategory(category);
            return View(appliances);
        }

        public IActionResult AddToCart(int id)
        {
            var products = _unitOfWork.Products.Get(id);
            if (products != null)
            {
                // Logic to add appliance to cart
            }
            return RedirectToAction("Index");
        }
    }
}