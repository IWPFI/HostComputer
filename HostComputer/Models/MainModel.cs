using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HostComputer.Base;

namespace HostComputer.Models
{
    public class MainModel : NotifyBase
    {
        private string? _time;
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <remarks>主窗体时间显示</remarks>
        public string Time
        {
            get { return _time; }
            set { _time = value; this.NotifyChanged(); }
        }

        private string? _userName;
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        /// <remarks>用户名</remarks>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; this.NotifyChanged(); }
        }

        private string? _avatar;
        /// <summary>
        /// Gets or sets the avatar.
        /// </summary>
        /// <remarks>用户头像</remarks>
        public string Avatar
        {
            get { return _avatar; }
            set { _avatar = value; this.NotifyChanged(); }
        }

        private UIElement _mainContent;
        /// <summary>
        /// Gets or sets the main content.
        /// </summary>
        /// <remarks></remarks>
        public UIElement MainContent
        {
            get { return _mainContent; }
            set { _mainContent = value; this.NotifyChanged(); }
        }

    }
}
