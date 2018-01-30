using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class DataAccessor<T> : IDataAccess
    {
        abstract public string DataName { get; }

        public event NotifyDataChangedEventHandler NotifyDataChanged;

        abstract protected T GetValueProcess(params int[] indexes);
        abstract protected void SetValueProcess(T value, params int[] indexes);
        abstract protected bool ValidationProcess(T value, params int[] indexes);

        public object GetValue(params int[] indexes)
        {
            return this.GetValueProcess(indexes);
        }

        public void SetValue(object value, params int[] indexes)
        {
            //データエラーチェック
            if (!this.ValidationProcess((T)value, indexes))
            {
                return;
            }

            //データの設定
            var beforeData = this.GetValueProcess(indexes);

            if (!beforeData.Equals(value))
            {
                this.SetValueProcess((T)value, indexes);
                this.NotifyDataChanged?.Invoke(this,
                    new NotifyDataChangedEventArgs
                    {
                        DataName = this.DataName,
                        Indexes = indexes
                    });
            }
        }
    }
}
