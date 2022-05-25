using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLesson.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentLessonContext _context;

        public StudentController(StudentLessonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }
        public IActionResult Create()
        {
            ViewData["Section"] = new SelectList(_context.Sections, "SectionId", "SectionName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var student = _context.Students
                .Include(k => k.Section)
                .First(sk => sk.SectionId == id);
            return View(student);
        }
    }
}
