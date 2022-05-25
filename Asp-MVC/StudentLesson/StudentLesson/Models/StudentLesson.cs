﻿namespace StudentLesson.Models
{
    public class StudentLesson
    {
        public int StudentLessonId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
