using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLesson.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }

        public DateTime? StudentDateOfBirth { get; set; }
        public DateTime? StudentDateOfRegistration { get; set; }
        public int StudentPeriod { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }

        public int SectionId { get; set; }
        public virtual Section Section { get; set; }

        
    }
}
