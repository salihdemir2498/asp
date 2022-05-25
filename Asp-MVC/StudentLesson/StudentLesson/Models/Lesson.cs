using System.Collections.Generic;

namespace StudentLesson.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonTeacher { get; set; }
        public int LessonCredit { get; set; }
        public int LessonPeriod { get; set; }
        public List<StudentLesson> StudentLessons { get; set; }
        public List<SectionLesson> SectionLessons { get; set; }


    }
}
