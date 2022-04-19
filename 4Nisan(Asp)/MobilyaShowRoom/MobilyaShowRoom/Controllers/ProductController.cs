using Microsoft.AspNetCore.Mvc;
using MobilyaShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = Repository.AllProducts();
            ViewBag.Title = "Products";
            return View(products);
        }

        public IActionResult GetProductDetail()
        {
            int id = Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            Product resultProduct = null;
            foreach (var item in MobilyaShowRoom.Models.Repository.AllProducts())
            {
                if (item.ID == id)
                {
                    resultProduct = item;
                    break;
                }
            }
            ViewBag.Product = resultProduct;
            ViewBag.Title = resultProduct.ProductName + " Ürün Detay Bilgisi";
            return View();
        }
    }
}
