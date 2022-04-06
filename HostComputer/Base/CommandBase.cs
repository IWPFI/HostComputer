using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HostComputer.Base
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Cans the execute.
        /// </summary>
        /// <remarks>是否可执行</remarks>
        public bool CanExecute(object parameter)
        {
            return true;
        }


        /// <summary>
        /// Executes the.
        /// </summary>
        /// <remarks></remarks>
        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }

        public Action<object> DoExecute { get; set; }
    }
}
