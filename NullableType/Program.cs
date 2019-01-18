using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int? ni = i; //<=>Nullable<int> i = 5;
            int? ni1 = null;
            int? ni2 = 1;

            Console.WriteLine(ni.HasValue);
            Console.WriteLine(ni1);
            Console.WriteLine(ni1.GetValueOrDefault(0));
            Console.WriteLine(ni2.HasValue ? ni2.Value : 9);

            Console.Read();
        }
    }
}
