using System.Collections.Generic;

namespace StudentLesson.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string SectionPresident { get; set; }
        public List<Student> Students { get; set; }
        public List<SectionLesson> SectionLessons { get; set; }
    }
}
