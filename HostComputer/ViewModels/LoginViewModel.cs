using HostComputer.Base;
using HostComputer.Models;
using HostComputer.Service;
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

        LoginService loginService = new LoginService();

        /// <summary>
        /// Gets or sets the user model.
        /// </summary>
        public UserModel UserModel { get; set; } = new UserModel();


        private string _errorMsg;
        /// <summary>
        /// Gets or sets the error msg.
        /// </summary>
        /// <remarks>设置错误消息</remarks>
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; this.NotifyChanged(); }
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

        private CommandBase _loginCommand;
        /// <summary>
        /// Gets the login command.
        /// </summary>
        /// <remarks>登录命令</remarks>
        public CommandBase LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new CommandBase();
                    _loginCommand.DoExecute = new Action<object>(obj =>
                    {
                        this.ErrorMsg = "";//将上一次的错误信息清空作用
                        try
                        {
                            if (loginService.CheckLogin(UserModel.UserName, UserModel.Password))//判断用户名和密码
                            {
                                (obj as System.Windows.Window).DialogResult = true;
                            }
                            else
                            {
                                throw new Exception("登录失败！用户名或密码错误");
                            }
                        }
                        catch (Exception ex)
                        {
                            this.ErrorMsg = ex.Message;
                        }
                    });
                }
                return _loginCommand;
            }
        }
    }
}
