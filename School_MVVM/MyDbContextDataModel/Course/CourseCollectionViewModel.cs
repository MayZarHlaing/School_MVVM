using System;
using System.Linq;
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
    /// Represents the Course collection view model.
    /// </summary>
    public partial class CourseCollectionViewModel : CollectionViewModel<Course, int, IMyDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CourseCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CourseCollectionViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CourseCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CourseCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CourseCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CourseCollectionViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Course)
        {
        }
    }
}