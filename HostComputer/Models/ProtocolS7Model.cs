using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Models
{
    public class ProtocolS7Model
    {
        public string IP { get; set; }
        public int Port { get; set; }
        public int Rock { get; set; }
        public int Slot { get; set; }
    }
}
