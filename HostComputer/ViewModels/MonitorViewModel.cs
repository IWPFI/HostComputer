using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostComputer.Base;

namespace HostComputer.Models
{
    public class MonitorViewModel : NotifyBase
    {
        public MonitorViewModel()
        {
            //添加运行状态
            //从数据为获取所有需要的显示的信息,进行数据获取,最后添加到集合,显示到界面上
            RunLabels.Add(new LabelModel { Texts = "当前对象", Values = "运行" });
            RunLabels.Add(new LabelModel { Texts = "周运行时长", Values = "80h" });
            RunLabels.Add(new LabelModel { Texts = "周关机时长", Values = "50h" });
            RunLabels.Add(new LabelModel { Texts = "周待机时长", Values = "50h" });
            RunLabels.Add(new LabelModel { Texts = "周故障时长", Values = "2h" });
            RunLabels.Add(new LabelModel { Texts = "健康状态", Values = "良好" });

            //基本信息
            BaseLabels.Add(new LabelModel { Texts = "最大工作范围", Values = "1.44m" });
            BaseLabels.Add(new LabelModel { Texts = "有效载荷", Values = "20kg" });
            BaseLabels.Add(new LabelModel { Texts = "有效轴数", Values = "6J" });
            BaseLabels.Add(new LabelModel { Texts = "重复定位精确度", Values = "0.001cm" });
            BaseLabels.Add(new LabelModel { Texts = "额定功率", Values = "2500w" });
            BaseLabels.Add(new LabelModel { Texts = "承重能力", Values = "5kg" });
            BaseLabels.Add(new LabelModel { Texts = "J6轴最大速度", Values = "2.1m/s" });
            BaseLabels.Add(new LabelModel { Texts = "电源电压", Values = "200-600v" });
            BaseLabels.Add(new LabelModel { Texts = "净重", Values = "225kg" });
        }

        public List<LabelModel> RunLabels { get; set; } = new List<LabelModel>();
        public List<LabelModel> BaseLabels { get; set; } = new List<LabelModel>();
       

    }
}
