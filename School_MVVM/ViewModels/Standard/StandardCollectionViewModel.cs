using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using School_MVVM.Common.Utils;
using School_MVVM.MyDbContextDataModel;
using School_MVVM.Common.DataModel;
using School_MVVM.DataModel;
using School_MVVM.DataBase;
using School_MVVM.Common.ViewModel;
using System.Collections.Generic;
using System.Windows;

namespace School_MVVM.ViewModels
{
    /// <summary>
    /// Represents the Standards collection view model.
    /// </summary>
    public partial class StandardCollectionViewModel : CollectionViewModel<School_MVVM.DataModel.Standard, int, IMyDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StandardCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StandardCollectionViewModel Create(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StandardCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StandardCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StandardCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StandardCollectionViewModel(IUnitOfWorkFactory<IMyDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Standards)
        {
        }
        public void Search(string des)
        {
            string standard;
            
        }
        IEnumerable<School_MVVM.DataModel.Standard> standards;
        public virtual IEnumerable<School_MVVM.DataModel.Standard> Standards
        {
            get{
               return standards;
            }
            set
            {
                //RefinedEntries = new ObservableCollection(_entries.Where(e => e.isActive).Select(e => e));
                var result1 = from r in Entities
                              where r.Description.Contains("1")
                              select r.Description;

                foreach (var r in result1)
                {
                    MessageBox.Show(r);
                    MessageBox.Show("Hello");
                }
            }
        }
     
    }
}