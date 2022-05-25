using DatabaseImageProject.Models.Concrete;
using DatabaseImageProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseImageProjectDbContext _context;
        public ProductController(DatabaseImageProjectDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Details(int id)
        {
            var category = _context.Products.Find(id);
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UploadImage()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/");
            //Birazdan resmin yüklenmesi işlemlerini tamamlayıp,buraya döneceğiz.
            var imageList = Directory.GetFiles(path);

            List<UploadImageModel> uploadImages = new List<UploadImageModel>();

            foreach (var image in imageList)
            {
                FileInfo fileInfo = new FileInfo(image);
                UploadImageModel model = new UploadImageModel();
                model.FullName = image.Substring(image.IndexOf("wwwroot")).Replace("wwwroot/", string.Empty);
                model.FileName = fileInfo.Name;
                model.Size = fileInfo.Length / 1024;
                uploadImages.Add(model);
            }

            return View(uploadImages);
        }

        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.Find(id);
            _context.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
