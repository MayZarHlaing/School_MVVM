using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace School_MVVM
{
    class ViewModelWithParametrizedCommand
    {
        public void DoSomething(int p)
        {
            MessageBox.Show(string.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", p));
        }
    }
}
