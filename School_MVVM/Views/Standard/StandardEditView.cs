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

namespace School_MVVM.Views.Standard
{
    [DevExpress.Utils.MVVM.UI.ViewType("StandardView")]
    public partial class StandardEditView : UserControl
    {
        public StandardEditView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<StandardViewModel>();
            fluent.SetObjectDataSourceBinding(standardBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(standardBindingSource, abs => abs.DataSource, x => x.LookUpStandards.Entities);
        }

     
}
}

