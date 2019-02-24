using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 6;
            int B = 9;
            Console.WriteLine("Max value is {0}", findMax(5, 14));
            Program pro = new Program();
            int rs = pro.sum(A,B);
            Console.WriteLine("Sum of {0} plus {1} is: {2}", A, B, rs);
            Console.ReadKey();
        }

        static int findMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public int sum(int numA, int numB)
        {
            return numA + numB;
        }
    }
}
