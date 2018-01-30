using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Data3Accessor : DataAccessor<int>
    {
        public override string DataName => "Data3";

        public Data3Accessor(RowData dataModel)
        {
            this.model = dataModel;
        }

        protected override int GetValueProcess(params int[] indexes)
        {
            return model.Data3[indexes[0]];
        }

        protected override void SetValueProcess(int value, params int[] indexes)
        {
            model.Data3[indexes[0]] = value;
        }

        protected override bool ValidationProcess(int value, params int[] indexes)
        {
            if (15 < value)
            {
                return false;
            }

            return true;
        }

        private RowData model;
    }
}
