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
using DevExpress.Mvvm.POCO;

namespace School_MVVM.Views.Course
{
    [DevExpress.Utils.MVVM.UI.ViewType("StudentCollectionView")]
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            
            InitializeComponent();
            var fluent = mvvmContext1.OfType<StudentCollectionViewModel>();
            fluent.SetBinding(gridControl1, j => j.DataSource, i => i.Entities);
            fluent.SetBinding(gridView1, g => g.LoadingPanelVisible, i => i.IsLoading);
            fluent.BindCommand(bbiTesting, s => s.Search());
        }
    }
}
