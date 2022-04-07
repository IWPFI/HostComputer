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
            //从全局缓存中获取用户信息(用户名),设置给界面
            MainModel.UserName = "Administartor";

            //设置时间
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

        private CommandBase _menuItemCommand;
        /// <summary>
        /// Switch menu commands.
        /// </summary>
        /// <remarks>切换菜单命令</remarks>
        public CommandBase MenuItemCommand
        {
            get
            {
                if (_menuItemCommand == null)
                {
                    _menuItemCommand = new CommandBase();
                    _menuItemCommand.DoExecute = new Action<object>(obj =>
                    {
                        //反射方法实现窗口切换
                        Type type = Type.GetType(obj.ToString());
                        this.MainModel.MainContent = (System.Windows.UIElement)Activator.CreateInstance(type);
                    });
                }
                return _menuItemCommand;
            }
        }
    }
}
