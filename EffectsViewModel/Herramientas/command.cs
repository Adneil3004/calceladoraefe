using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EffectsViewModel.Herramientas
{
    public class command : ICommand
    {
        private Action<object> execAction;
        private Predicate<object> canExecute;

        

        public command(Action<object> execAction)
        {
            this.execAction = execAction;
            this.canExecute = null;
        }//Fin de constructor.

        public command(Action<object> execAction, Predicate<object> canExecFunc)
        {
            this.execAction = execAction;
            this.canExecute = canExecFunc;
        }//Fin de constructor.

        public event EventHandler CanExecuteChanged;

        bool ICommand.CanExecute(object parameter)
        {
            if (parameter != null)
                return canExecute(parameter);
            else return true;

        }

        void ICommand.Execute(object parameter)
        {
            if (execAction != null)
            {
                execAction.Invoke(parameter);
            }//Fin de if.
        }


    }//Fin de clase.
}