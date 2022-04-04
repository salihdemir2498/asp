using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Mvc_01.Controllers
{
    //Eğer bir clasın controller davranışı sergilemesini yani;
    //gelen bir requesti karşılayabilir özellik kazanmasını istiyorsak
    //o classı Controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Action Method: Eğer bir method bir controller içindeyse 
            //buna Action Method diyoruz. Hatta çoğu kez sadece Action sözcüğü ile ifade edilebilir.

            //Bu action uygulamamızın ana sayfasına girildiğinde tetiklenecek.
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}