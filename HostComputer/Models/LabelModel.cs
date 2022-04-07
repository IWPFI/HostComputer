using HostComputer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Models
{
    public class LabelModel : NotifyBase
    {
        private string texts;

        public string Texts
        {
            get { return texts; }
            set { texts = value; this.NotifyChanged(); }
        }

        private string values;

        public string Values
        {
            get { return values; }
            set { values = value; this.NotifyChanged(); }
        }

    }
}
