using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 3, 6, -2, -5, 7, 3 };
            int tmp = Int32.MinValue;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] * inputArray[j] > tmp)
                    {
                        tmp = inputArray[i] * inputArray[j];
                    }
                    break;
                }
            }
            Console.WriteLine(tmp);
            Console.Read();
        }
    }
}
