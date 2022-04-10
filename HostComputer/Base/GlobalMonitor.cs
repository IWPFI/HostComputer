using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostComputer.Models;
using HostComputer.Service;

namespace HostComputer.Base
{
    public class GlobalMonitor
    {
        public static ObservableCollection<DeviceModel> DeviceList { get; set; } = new ObservableCollection<DeviceModel>();//获取设备集合

        static bool isRunning = true;
        static Task mainTask = null;

        public static void Start()//开始监控
        {
            Task.Run(async () =>
            {
                //获取设备信息
                DeviceService deviceService = new DeviceService();
                var list = deviceService.GetDevices();
                if (list != null)
                    list.ForEach(l => DeviceList.Add(l));
                    //DeviceList = new ObservableCollection<DeviceModel>(list);

                while (isRunning)
                {
                    await Task.Delay(100);

                    foreach (var item in DeviceList)
                    {
                        if (item.ProtocolType == 2 && item.S7 != null)// S7通信
                        {
                            //创建S7通信对象
                            Zhaoxi.Communication.Siemens.S7Net s7Net = new Zhaoxi.Communication.Siemens.S7Net(item.S7.IP, item.S7.Port, (byte)item.S7.Rock, (byte)item.S7.Slot);

                            //整理存储区地址
                            //VW100   DB.DBW100
                            //List<string> { "VW100", "DB.DBW100"}
                            List<string> addrList = item.MonitorValueList.Select(v => v.Address).ToList();
                            //通信协议处理
                            var result = s7Net.Read<ushort>(addrList);
                            //数据List
                            if (result.IsSuccessed)
                            {
                                for (int i = 0; i < item.MonitorValueList.Count; i++)
                                {
                                    item.MonitorValueList[i].Value = result.Datas[i];
                                }
                            }
                            //连接关闭
                            s7Net.Close();
                        }
                    }
                }
            });
        }

        public static void Stop()
        {
            isRunning = false;
            mainTask.ConfigureAwait(true);
        }
    }
}
