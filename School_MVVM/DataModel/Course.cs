using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_MVVM.DataModel
{
   public class Course
    {
        public Course()
        {
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        //public string Grade { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
