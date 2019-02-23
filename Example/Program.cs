using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            sbyte typeSbyte = 1;   //-128 to 127
            byte typeByte = 0;  //0 to 255
            short typeShort = 0;  //-32,768 to 32,767
            int typeInt = 0;    //-2,147,483,648 to 2,147,483,647
            uint typeUint = 0;  //0 to 4,294,967,295
            long typeLong = 0;  //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong typeUlong = 0;    //0 to 18,446,744,073,709,551,615
            Console.WriteLine(typeSbyte + "-" + typeByte + "-" + typeShort + "-" + typeInt + "-" + typeUint + "-" + typeLong + "-" + typeUlong);

            // Example 2
            float num1 = 0.000001f;
            float num2 = 0.000002f;
            Console.WriteLine(num1 > num2 ? "num1" : "num2");

            // Example 3
            string str = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(str);

            // Example 4
            int a = 52;
            int b = 101;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a + "; b = " + b + ";");

            //Example 5
            string[] arr = { "A", "B", "C", "D", "E" };
            string content = "a a A b B b bbbbb c c c s s s r C d D";

            string[] words = content.Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for(int j=0; j < arr.Length; j++)
                {
                    if(arr[j] == words[i])
                    {
                        count += 1;
                    }   
                }

            }

            //Example 6
            int numA = 2;
            int numB = 5;
            Console.WriteLine("Value is: " + numA + numB);

            //Example 7
            int inputInt;
            string result;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Input your number: ");
            String input = Console.ReadLine();
            inputInt = Int32.Parse(input);
            result = (inputInt % 2 == 0) ? "This is even number!" : "This is odd number!";
            Console.WriteLine("Your number input: {0} and {1}",input, result);


            //Example 8: Tính năm âm lịch
            string Can = "", Chi = "";
            int Year;

            Console.WriteLine("Nhap vao nam sinh cua ban:");
            Year = Int32.Parse(Console.ReadLine());

            switch (Year % 10)
            {
                case 0: 
                    Can = "Canh";
                    break;
                case 1:
                    Can = "Tan";
                    break;
                case 2:
                    Can = "Nham";
                    break;
                case 3:
                    Can = "Quy";
                    break;
                case 4:
                    Can = "Giap";
                    break;
                case 5:
                    Can = "At";
                    break;
                case 6:
                    Can = "Binh";
                    break;
                case 7:
                    Can = "Dinh";
                    break;
                case 8:
                    Can = "Mau";
                    break;
                case 9:
                    Can = "Ky";
                    break;
            }

            switch (Year % 12)
            {
                case 0:
                    Chi = "Than";
                    break;
                case 1:
                    Chi = "Dau";
                    break;
                case 2:
                    Chi = "Tuat";
                    break;
                case 3:
                    Chi = "Hoi";
                    break;
                case 4:
                    Chi = "Ty";
                    break;
                case 5:
                    Chi = "Suu";
                    break;
                case 6:
                    Chi = "Dan";
                    break;
                case 7:
                    Chi = "Meo";
                    break;
                case 8:
                    Chi = "Thin";
                    break;
                case 9:
                    Chi = "Ti";
                    break;
                case 10:
                    Chi = "Ngo";
                    break;
                case 11:
                    Chi = "Mui";
                    break;
            }

            Console.WriteLine("Nam sinh am lich cua ban la : {0} {1}", Can, Chi);

            Console.Read();
        }
    }
}
