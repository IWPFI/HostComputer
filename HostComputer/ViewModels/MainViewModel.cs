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
    /// The main view model.
    /// </summary>
    public class MainViewModel
    {
        public MainModel MainModel { get; set; } = new MainModel();

        public MainViewModel()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(500);
                    this.MainModel.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            });
        }

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
