using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_MVVM.ViewModels.Login;

namespace School_MVVM.Views.Login
{
       [DevExpress.Utils.MVVM.UI.ViewType("LoginView")]
    public partial class LoginFormView : UserControl
    {
        
        public LoginFormView()
        {
            InitializeComponent();
        }
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            var fluentAPI = mvvmContext1.OfType<LoginViewModel>();
            fluentAPI.SetObjectDataSourceBinding(userBindingSource,
                x => x.CurrentUser, x => x.Update());

            foreach (string item in mvvmContext1.GetViewModel<LoginViewModel>().LookUpUsers)
                LoginTextEdit.Properties.Items.Add(item);
            fluentAPI.ViewModel.Init();
        }
    }
}
