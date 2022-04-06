using HostComputer.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HostComputer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            if (new LoginWindow().ShowDialog() == true)
            {
                new MainWindow().ShowDialog();
            }
            Application.Current.Shutdown();
        }
    }
}
