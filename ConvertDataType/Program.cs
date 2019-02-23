using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // chuyển đổi kiểu ngầm định
            int i = 5;
            long l = i; // long có miền giá trị lớn hơn nên có thể chuyển đổi ngầm

            // chuyển đổi kiểu tường minh
            int q = 300;
            byte b = (byte)q;

            int r = 5;
            int t = 2;
            float y = (float)r / t; //=> 2,5
            float y1 = r*1.0f / t; //=> 2,5

            // Parse()
            string w = "32";
            int e = Int32.Parse(w);

            // TryParse()
            int result;
            bool isSuccess;
            string data1 = "10", data2 = "test";

            isSuccess = int.TryParse(data1, out result);
            Console.WriteLine(isSuccess == true ? "Success!" : "Failed!");
            Console.WriteLine("Result: " + result);

            isSuccess = int.TryParse(data2, out result);
            Console.WriteLine(isSuccess == true ? "Success!" : "Failed!");
            Console.WriteLine("Result: " + result);

            Console.Read();
        }
    }
}
