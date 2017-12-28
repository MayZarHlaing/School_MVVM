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
    /// IMyDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IMyDbContextUnitOfWork : IUnitOfWork
    {

        /// <summary>
        /// The Course entities repository.
        /// </summary>
        IRepository<Course, int> Course { get; }

        /// <summary>
        /// The Student entities repository.
        /// </summary>
        IRepository<Student, int> Students { get; }

        /// <summary>
        /// The Standard entities repository.
        /// </summary>
        IRepository<School_MVVM.DataModel.Standard, int> Standards { get; }
    }
}
