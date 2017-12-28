using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_MVVM.DataModel
{
    public class Standard
    {
        public Standard()
        {
       
        }
        public int StandardId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
