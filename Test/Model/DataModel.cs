using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DataModel
    {
        private RowData rowData = new RowData();
        private List<IDataAccess> dataAccessorList;

        public DataModel()
        {
            dataAccessorList = new List<IDataAccess>
            {
                new Data1Accessor(this.rowData),
                new Data3Accessor(this.rowData),
            };
        }

        public object GetValue(string dataName, params int[] indexes)
        {
            return this.dataAccessorList
                .First(x => dataName.Equals(x.DataName))
                .GetValue(indexes);
        }

        public void SetValue(object value, string dataName, params int[] indexes)
        {
            this.dataAccessorList
                .First(x => dataName.Equals(x.DataName))
                .SetValue( value, indexes);
        }

    }
}
