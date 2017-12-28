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
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;

namespace School_MVVM.MyDbContextDataModel
{
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IMyDbContextUnitOfWork> GetUnitOfWorkFactory()
        {
            return new DbUnitOfWorkFactory<IMyDbContextUnitOfWork>(() => new MyDbContextUnitOfWork(() => new MyDbContext()));
        }
    }
}