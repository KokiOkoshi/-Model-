using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IDataAccess : INotifyDataChanged
    {
        string DataName { get; }

        object GetValue(params int[] indexes);
        void SetValue(object value, params int[] indexes);
    }
}
