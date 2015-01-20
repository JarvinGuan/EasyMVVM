using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace EasyMVVM.Core
{
    public class EasyCommand: ICommand
    {

        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc != null)
            {
                return this.CanExecuteFunc(parameter);
            }

            return true;


        }
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (this.ExecuteAction != null)
            {
                this.ExecuteAction(parameter);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public Func<object, bool> CanExecuteFunc { set; get; }

        public Action<object> ExecuteAction { set; get; }
    }
}
