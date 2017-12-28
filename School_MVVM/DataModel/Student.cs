using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_MVVM.DataModel
{
  public  class Student
    {
        public Student() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public virtual Standard Standard { get; set; }
        public virtual Course Course { get; set; }
    }
}
