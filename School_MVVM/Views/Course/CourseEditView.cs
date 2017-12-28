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

namespace School_MVVM.Views.Course
{
    [DevExpress.Utils.MVVM.UI.ViewType("CourseView")]
    public partial class CourseEditView : UserControl
    {
        public CourseEditView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<CourseViewModel>();
            fluent.SetObjectDataSourceBinding(courseBindingSource, x => x.Entity, x => x.Update());
        }
    }
}
