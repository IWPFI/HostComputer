using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HostComputer.Base
{
    public class WindowManager
    {
        static Dictionary<string, WindowStruct> _regWindows = new Dictionary<string, WindowStruct>();

        public static void Register<T>(string name, Window owner = null)
        {
            if (!_regWindows.ContainsKey(name))
                _regWindows.Add(name, new WindowStruct { WindowType = typeof(T), Owner = owner });
        }
        public static bool ShowDialog(string name, object vm)
        {
            if (_regWindows.ContainsKey(name))
            {
                Type type = _regWindows[name].WindowType;

                var win = (Window)Activator.CreateInstance(type);
                win.Owner = _regWindows[name].Owner;
                win.DataContext = vm;
                return win.ShowDialog() == true;
            }
            return false;
        }
    }

    public class WindowStruct
    {
        public Type WindowType { get; set; }
        public Window Owner { get; set; }
    }
}
