using School_MVVM.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_MVVM.DataBase
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name = SchoolContext")
        {

        }
        static MyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<MyDbContext>(null);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School_MVVM.DataModel.Standard> Standards { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
