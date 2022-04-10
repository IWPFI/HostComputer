using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostComputer.Base;

namespace HostComputer.Models
{
    public class DeviceModel : NotifyBase
    {
        private CommandBase _editCommand;
        /// <summary>
        /// 打开编辑窗口
        /// </summary>
        public CommandBase EditCommand
        {
            get
            {
                if (_editCommand == null)
                {
                    _editCommand = new CommandBase();
                    _editCommand.DoExecute = new Action<object>(obj =>
                    {
                        //不能直接访问子元素
                        WindowManager.ShowDialog("DeviceEditWindow", this);//只是打开窗口
                    });
                }
                return _editCommand;
            }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; this.NotifyChanged(); }
        }

        private string _sn;

        public string SN
        {
            get { return _sn; }
            set { _sn = value; this.NotifyChanged(); }
        }

        private int _param1;

        public int Param1
        {
            get { return _param1; }
            set { _param1 = value; this.NotifyChanged(); }
        }

        /// <summary>
        /// 协议类型
        /// </summary>
        public int ProtocolType { get; set; }
        public ProtocolS7Model S7 { get; set; }
        public ProtocolModbus Modbus { get; set; }
        public ObservableCollection<MonitorValueModel> MonitorValueList { get; set; } = new ObservableCollection<MonitorValueModel>();

        //报警
        //报警信息提示
    }
}
