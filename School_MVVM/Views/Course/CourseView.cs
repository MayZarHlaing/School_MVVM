using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_MVVM.ViewModels;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace School_MVVM.Views.Course
{
    [DevExpress.Utils.MVVM.UI.ViewType("CourseCollectionView")]
    public partial class CourseView : UserControl
    {
        public CourseView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<CourseCollectionViewModel>();
            fluent.SetBinding(gridView1, b => b.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, d => d.DataSource, x => x.Entities);
            fluent.WithEvent<DevExpress.XtraGrid.Views.Base.ColumnView, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
    .SetBinding(x => x.SelectedEntity, args => args.Row as DataModel.Course, (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));


        }
        protected IMessageBoxService MessageBoxService { get { return this.GetRequiredService<IMessageBoxService>(); } }
    }
}
