using HostComputer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Models
{
    public class UserModel : NotifyBase
    {
        private string? _userName;
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                this.NotifyChanged();
            }
        }

        private string _password = "";

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                this.NotifyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the real name.
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// Gets or sets the avatar.
        /// </summary>
        public string Avatar { get; set; }
    }
}
