using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new DataModel();

            Console.WriteLine(model.GetValue("Data3",0));

            model.SetValue(15, "Data3", 0);
            Console.WriteLine(model.GetValue("Data3", 0));
        }
    }
}
