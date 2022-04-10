using HostComputer.Base;
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
        //GlobalMonitor globalMonitor = new GlobalMonitor();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            GlobalMonitor.Start();

            if (new LoginWindow().ShowDialog() == true)
            {
                new MainWindow().ShowDialog();
            }
            Application.Current.Shutdown();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            GlobalMonitor.Stop();
            base.OnExit(e);
        }
    }
}
