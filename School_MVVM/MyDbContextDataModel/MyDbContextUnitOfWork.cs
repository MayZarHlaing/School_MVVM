using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using School_MVVM.Common.Utils;
using School_MVVM.Common.DataModel;
using School_MVVM.Common.DataModel.EntityFramework;
using School_MVVM.DataBase;
using School_MVVM.DataModel;

namespace School_MVVM.MyDbContextDataModel
{
    /// <summary>
    /// A MyDbContextUnitOfWork instance that represents the run-time implementation of the IMyDbContextUnitOfWork interface.
    /// </summary>
    public class MyDbContextUnitOfWork : DbUnitOfWork<MyDbContext>, IMyDbContextUnitOfWork
    {

        public MyDbContextUnitOfWork(Func<MyDbContext> contextFactory)
            : base(contextFactory)
        {
        }

        IRepository<Course, int> IMyDbContextUnitOfWork.Course
        {
            get { return GetRepository(x => x.Set<Course>(), x => x.CourseId); }
        }

        IRepository<Student, int> IMyDbContextUnitOfWork.Students
        {
            get { return GetRepository(x => x.Set<Student>(), x => x.StudentId); }
        }

        IRepository<School_MVVM.DataModel.Standard, int> IMyDbContextUnitOfWork.Standards
        {
            get { return GetRepository(x => x.Set<School_MVVM.DataModel.Standard>(), x => x.StandardId); }
        }
    }
}
