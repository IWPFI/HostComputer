using HostComputer.Base;
using HostComputer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.ViewModels
{
    /// <summary>
    /// The login view model.
    /// </summary>
    public class LoginViewModel : NotifyBase
    {
        public LoginViewModel()
        {
            UserModel.UserName = "admin";
        }

        /// <summary>
        /// Gets or sets the user model.
        /// </summary>
        public UserModel UserModel { get; set; } = new UserModel();

        private CommandBase _closeCommand;
        /// <summary>
        /// Gets the close command.
        /// </summary>
        /// <remarks>关闭命令</remarks>
        public CommandBase CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new CommandBase();
                    _closeCommand.DoExecute = new Action<object>(obj =>
                    {
                        (obj as System.Windows.Window).DialogResult = false;
                    });
                }
                return _closeCommand;
            }
        }
    }
}
