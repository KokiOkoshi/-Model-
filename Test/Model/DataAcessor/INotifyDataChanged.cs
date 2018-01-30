using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface INotifyDataChanged
    {
        event NotifyDataChangedEventHandler NotifyDataChanged;
    }

    delegate void NotifyDataChangedEventHandler(object sender, NotifyDataChangedEventArgs e);

    class NotifyDataChangedEventArgs
    {
        public string DataName { get; set; } = string.Empty;
        public int[] Indexes = new int[0];
    }

}
