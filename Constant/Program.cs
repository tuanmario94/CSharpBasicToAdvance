using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = 'a';
            Console.WriteLine(character);

            character = '\u003A';
            Console.WriteLine(character);

            character = '\'';
            Console.WriteLine(character);

            character = '\"';
            Console.WriteLine(character);

            character = '\\';
            Console.WriteLine(character);

            string quotation = "\"Hello, Tuan\", he said.";
            Console.WriteLine(quotation);

            string path = "C:\\Windows\\system32";
            Console.WriteLine(path);

            string verbatim = @"The \ is not escaped as \\.I am at the new line.";
            Console.WriteLine(verbatim);

            string str = "line 1 \n line 2";
            Console.WriteLine(str);

            Console.Read();
        }
    }
}
