using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoubleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatPI = 3.14f;
            Console.WriteLine(floatPI);
            double doublePI = 3.14d;
            Console.WriteLine(doublePI);
            double nan = Double.NaN;
            Console.WriteLine(nan);
            double ifinity = Double.PositiveInfinity;
            Console.WriteLine(ifinity);

            Console.Read();
        }
    }
}
