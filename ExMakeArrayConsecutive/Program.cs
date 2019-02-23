using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMakeArrayConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = { 6, 2, 3, 8 };
            int tmp = 0;
            Array.Sort(statues);
            for (int i = 0; i < statues.Length - 1; i++)
            {
                if(statues[i+1] > statues[i] + 1)
                {
                    tmp += statues[i + 1] - statues[i];
                    tmp--;
                }
            }
            Console.WriteLine(tmp);
            Console.Read();
        }
    }
}
