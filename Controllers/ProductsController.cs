using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Lab_01_CoffeeShop.Models;
using Lab_01_CoffeeShop;
using Dapper;

namespace Lab_01_CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1; Database=coffeeshop; Uid=root; Pwd=Fidan1280!;");
            IEnumerable<Products> prods = db.GetAll<Products>();
            return View(prods);          
        }

        public IActionResult Detail(int Id)
        {
            var db = new MySqlConnection("Server=127.0.0.1; Database=coffeeshop; Uid=root; Pwd=Fidan1280!;");
            Products prod = db.Get<Products>(Id);
           
            List<Products> prods = db.Query<Products>
                                 ($"select * from Products where Id = '{Id}'").ToList();
            ViewData["products"] = prods;
            return View(prod);
        }
    }
}
