using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare way 1:
            string[] arrStudent = new string[3];
            for (int i = 0; i < arrStudent.Length; i++)
            {
                Console.WriteLine("Student[{0}] : {1}",i,arrStudent[i]);
            }
            // Declare way 2:
            string[] name = new string[] { "Jame", "Alex", "Junio" };
            // Declare way 3:
            int[] age = { 23, 65, 21, 54, 12 };

            #region Example 1
            // Example 1:
            int Year; // Biến chứa giá trị năm cần tính.
            // Mảng Can chứa các giá trị can tương ứng theo bảng can
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            // Mảng Chi chứa các giá trị chi tương ứng theo bảng chi
            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };


            Console.Write(" Moi ban nhap mot nam bat ky: ");

            // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            Year = Int32.Parse(Console.ReadLine());


            /*
             * Vì kết quả phép chia lấy dư của Year%10 hoặc Year%12 sẽ cho ra số nguyên
             * Nên ta sẽ dùng nó làm chỉ số phần tử để tra cứu ra giá trị can chi tương ứng. Thay vì dùng cách cũ là switch case
             * Như vậy cách này vừa đơn giản vừa dễ hiểu, code rất ít sẽ với cách dùng switch case
             */

            Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year % 10], Chi[Year % 12]); // Nối Can và Chi lại để được năm âm lịch
            #endregion

            #region Example 2
            //Example 5
            string[] arr = { "A", "B", "C", "D", "E" };
            string content = "a a A b B B bbbbb c c c s s s r C d D";

            string[] words = content.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (arr[i] == words[j])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine("Element {0} apear: {1} time", arr[i], count);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
