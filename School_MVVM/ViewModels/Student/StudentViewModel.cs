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
    /// Represents the single Student object view model.
    /// </summary>
    public partial class StudentViewModel : SingleObjectViewModel<Student, int, IMyDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StudentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StudentViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StudentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StudentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StudentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StudentViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Students, x => x.StudentName)
        {
        }

        /// <summary>
        /// The view model that contains a look-up collection of Course for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Course> LookUpCourse
        {
            get { return GetLookUpEntitiesViewModel((StudentViewModel x) => x.LookUpCourse, x => x.Course); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Standards for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<School_MVVM.DataModel.Standard> LookUpStandards
        {
            get { return GetLookUpEntitiesViewModel((StudentViewModel x) => x.LookUpStandards, x => x.Standards); }
        }
    }
}
