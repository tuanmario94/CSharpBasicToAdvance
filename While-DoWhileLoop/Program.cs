using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            ///While:
            // Example 1: Run matrix
            int countLoopTime = 0;
            int valueNum = 10;
            int loopTime = 500;
            int minRandomValue = 0;
            int maxRandomValue = 1000;

            Random rd = new Random();

            while (countLoopTime < loopTime)
            {
                int countLoop = 0;
                while (countLoop < valueNum)
                {
                    int showValue = rd.Next(minRandomValue, maxRandomValue);
                    Console.Write("{0,8}", showValue);
                    countLoop++;
                }
                Console.WriteLine();
                countLoopTime++;
            }

            //Example 2: Vẽ hình chữ nhật
            int vertical = 10;
            int horizontal = 20;
            int countVertical = 0;
            int countHorizontal = 0;
            string drawChar = "#";
            string insideChar = "-";

            while (countVertical < vertical)
            {   
                countHorizontal = 0;
                while (countHorizontal < horizontal)
                {
                    if (countVertical % (vertical - 1) == 0 || countHorizontal % (horizontal - 1) == 0)
                        Console.Write(drawChar);
                    else
                        Console.Write(insideChar);
                    countHorizontal++;
                }
                countVertical++;
                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}
