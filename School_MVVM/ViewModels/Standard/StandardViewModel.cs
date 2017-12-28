using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using School_MVVM.Common.Utils;
using School_MVVM.MyDbContextDataModel;
using School_MVVM.Common.DataModel;
using School_MVVM.DataModel;
using School_MVVM.DataBase;
using School_MVVM.Common.ViewModel;

namespace School_MVVM.ViewModels
{
    /// <summary>
    /// Represents the single Standard object view model.
    /// </summary>
    public partial class StandardViewModel : SingleObjectViewModel<School_MVVM.DataModel.Standard, int, IMyDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StandardViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StandardViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StandardViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StandardViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StandardViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StandardViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Standards, x => x.Description)
        {
        }
        public IEntitiesViewModel<School_MVVM.DataModel.Standard> LookUpStandards
        {
            get { return GetLookUpEntitiesViewModel((StandardViewModel x) => x.LookUpStandards, x => x.Standards); }
        }
    }
}
