namespace StudentLesson.Models
{
    public class SectionLesson
    {
        public int SectionLessonId { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
