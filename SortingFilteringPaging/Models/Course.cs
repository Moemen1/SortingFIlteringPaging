using System.Collections.Generic;

namespace SortingFilteringPaging.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public List<Enrollment> Enrollment { get; set; }
    }
}