using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Data1Accessor : DataAccessor<int>
    {
        public override string DataName => "Data1";

        public Data1Accessor( RowData dataModel)
        {
            this.model = dataModel;
        }

        protected override int GetValueProcess(params int[] indexes)
        {
            return model.Data1;
        }

        protected override void SetValueProcess(int value, params int[] indexes)
        {
            model.Data1 = value;
        }

        protected override bool ValidationProcess(int value, params int[] indexes)
        {
            if (10 < value )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private RowData model;
    }
}
