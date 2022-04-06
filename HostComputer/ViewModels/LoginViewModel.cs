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
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            UserModel.UserName = "admin";
        }

        /// <summary>
        /// Gets or sets the user model.
        /// </summary>
        public UserModel UserModel { get; set; } = new UserModel();
    }
}
