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
    /// Represents the Students collection view model.
    /// </summary>
    public partial class StudentCollectionViewModel : CollectionViewModel<Student, int, IMyDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StudentCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StudentCollectionViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StudentCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StudentCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StudentCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StudentCollectionViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Students)
        {
        }

        public void Search()
        {
       
        }
    }
}