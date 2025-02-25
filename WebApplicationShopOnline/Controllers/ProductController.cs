// контроллер создавать пустой!
using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Index(string name, string description, decimal price)
        {
            Product product = new Product(name, description, price);
            return product.ToString();
        }
    }
}
