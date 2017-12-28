using DevExpress.Mvvm;
using School_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_MVVM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                initBindings();
            }
        }
        void initBindings()
        {
            int i=4;
            var fluent = mvvmContext1.OfType<MyDbContextViewModel>();
            fluent.BindCommand(bbiStudent,(x,m)=>x.Show(m),x=>x.Modules[0]);
            fluent.BindCommand(bbiStandard, (x, m) => x.Show(m), x => x.Modules[1]);
            fluent.BindCommand(bbiCourse, (x, m) => x.Show(m), x => x.Modules[2]);
            fluent.WithEvent<EventArgs>(this, "Load").EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
            bbiCommand.BindCommand(command, () => i);
            fluent.SetTrigger(x => x.State, (state) =>
            {
                if (state == AppState.Autorized)
                    Opacity = 1; /*Show Main Form*/
                if (state == AppState.ExitQueued)
                    Close(); // exit the app; 
            });
            Messenger.Default.Register<string>(this, OnUserNameMessage);
            fluent.BindCommand(bbiLogOut, d => d.LogOut());
            
            mvvmContext1.WithEvent<FormClosingEventArgs>(this, "FormClosing").Confirmation(behavior =>
                {
                    behavior.Caption = "Confirmation";
                    behavior.Text = "Do you really want to close this app?";
                    behavior.Buttons = DevExpress.Utils.MVVM.ConfirmationButtons.YesNo;

                });
        }

        private void OnUserNameMessage(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                this.Text = "Expenses Application";
            else
                this.Text = "Expenses Application - (" + userName + ")";
        }
        DelegateCommand<int> command = new DelegateCommand<int>((v) =>
        {
            MessageBox.Show(string.Format("Hello! I'm running!{0}", v));
        }, canExecute);

        private static bool canExecute(int p)
        {
            return 2 + 2 == p;
        }

        private void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectedPage = e.MergedChild.SelectedPage;
        }

    
       
    }

  
}
