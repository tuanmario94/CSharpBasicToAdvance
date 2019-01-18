using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = 20;
            ushort year = 2000;

            decimal decimalPI = 3.141592m;

            bool isEmpty = true;
            char ch = 'a';

            string firstName = "John";

            ch = (char)5;
            char secondChar;

            secondChar = ch;

            Console.WriteLine("Centuries is: " + centuries);
            Console.WriteLine("Year is: " + year);
            Console.WriteLine("DecimalPi is: " + decimalPI);
            Console.WriteLine("Empty is: " + isEmpty);
            Console.WriteLine("Char is: " + ch);
            Console.WriteLine("FirstName is: " + firstName);
            Console.WriteLine("SecondChar is: " + secondChar);
            Console.Read();
        }
    }
}
