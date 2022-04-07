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
            this.NavPage("HostComputer.Views.MonitorView");//设置首次启动时启动首页

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

        /// <summary>
        /// Application Switcher
        /// </summary>
        /// <remarks>反射方法实现窗口切换</remarks>
        private void NavPage(string name)
        {
            Type type = Type.GetType(name);
            this.MainModel.MainContent = (System.Windows.UIElement)Activator.CreateInstance(type);
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
                        NavPage(obj.ToString());
                    });
                }
                return _menuItemCommand;
            }
        }
    }
}
