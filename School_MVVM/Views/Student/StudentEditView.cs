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
    [DevExpress.Utils.MVVM.UI.ViewType("StudentView")]
    public partial class StudentEditView : UserControl
    {
        public StudentEditView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<StudentViewModel>();
            fluent.SetObjectDataSourceBinding(studentBindingSource, x => x.Entity, x => x.Update());
            ////var fluent1 = mvvmContext2.OfType<CourseViewModel>();
            fluent.SetBinding(courseBindingSource, abs => abs.DataSource, x => x.LookUpCourse.Entities);
            fluent.SetBinding(standardBindingSource, abs => abs.DataSource, x => x.LookUpStandards.Entities);

        }

        private void dataLayoutControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
