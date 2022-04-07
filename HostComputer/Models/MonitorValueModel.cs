using HostComputer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Models
{
    public class MonitorValueModel : NotifyBase
    {
        public string ValueId { get; set; }

        /// <summary>
        /// 数据名称
        /// </summary>
        public string ValueName { get; set; }

        /// <summary>
        /// 数据地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        private object _value;
        /// <summary>
        /// 当前值
        /// </summary>
        public object Value
        {
            get { return _value; }
            set { _value = value; this.NotifyChanged(); }
        }

        //报警
        //需要设置的报警信息

    }
}
