﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            bool greaterAB = (a > b);

            if(greaterAB == true)
            {
                Console.WriteLine("A > B!");
            }
            else
            {
                Console.WriteLine("A < B!");
            }

            Console.ReadKey();
        }
    }
}
