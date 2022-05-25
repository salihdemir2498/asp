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
    public class StudentLessonController : Controller
    {
        private readonly StudentLessonContext _context;

        public StudentLessonController(StudentLessonContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
            
        //}

        public IActionResult AssignLesson()
        {
            //var student = _context.StudentLessons
            // .Include(k => k.Lesson)
            // .Include(k => k.Student);
            //return View(student);
            

            return View(_context.Students.ToList());
        }

        public Student GetByIdWithCourses(int id)
        {
            using (var context = new StudentLessonContext())
            {
                return context.Students
                    .Where(x => x.StudentId == id)
                    .Include(x => x.StudentLessons)
                    .ThenInclude(x => x.Lesson)
                    .FirstOrDefault();
            }
        }

        public IActionResult Assign(int id)
        {
            //var model2 = new Lesson();
            var context = new Student();
            var entity = GetByIdWithCourses(id);
            var model = new StudentModel()
            {
                StudentId = entity.StudentId,
                StudentNo = entity.StudentNo,
                StudentName = entity.StudentName,
                StudentSurname = entity.StudentSurname,
                StudentDateOfBirth = entity.StudentDateOfBirth,
                StudentDateOfRegistration = entity.StudentDateOfRegistration,
                StudentPeriod = entity.StudentPeriod,
                SectionId = entity.SectionId,
                SelectedLessons = entity.StudentLessons.Select(x => x.Lesson).ToList()
            };
            ViewBag.lessons = _context.Lessons.ToList(); 
            return View(model);
        }
    }
}
