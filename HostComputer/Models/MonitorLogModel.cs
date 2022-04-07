using HostComputer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HostComputer.Models
{
    public class MonitorLogModel
    {
        /// <summary>序号</summary>
        public string Number { get; set; }

        /// <summary>数据类型</summary>
        public string DataType { get; set; }

        /// <summary>记录日期</summary>
        public string RecordTime { get; set; }

        /// <summary>设备名称</summary>
        public string DeviceName { get; set; }

        /// <summary>温度值</summary>
        public string Value { get; set; }

        /// <summary>状态</summary>
        public string Status { get; set; }

        private CommandBase _detailCommand;

        public CommandBase DetailCommand
        {
            get
            {
                if (_detailCommand == null)
                {
                    _detailCommand = new CommandBase();
                    _detailCommand.DoExecute = new Action<object>(ShowDetail);
                }
                return _detailCommand;
            }
        }

        //详情点击委托方法
        private void ShowDetail(object obj)
        {
            MessageBox.Show(this.Number);
        }

    }
}
