using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // vẽ hình chữ nhật màu xanh 30x50
            int N = 6;
            int M = 8;
            string drawChar = "*";
            string insideChar = "@";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i % (N - 1) == 0 || j % (M - 1) == 0)
                    //if (i == 0 || j == 0 || i == N - 1 || j == M - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(drawChar);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(insideChar);
                    }
                }
                Console.WriteLine();
            }


            // vẽ hình tròn
            Console.Write("Nhap ban kinh hinh tron r = ");
            if (!int.TryParse(Console.ReadLine(), out int r) || r <= 0)
            {
                Console.WriteLine("Ban kinh nhap vao khong hop le");
                return;
            }
            Console.Clear();
            double rin = r - 0.5;
            double rout = r + 0.5;
            for (int i = -r; i <= r; i++)
            {
                for (double j = -r; j <= r; j += 0.5)
                {
                    double f = i * i + j * j;
                    if (f >= rin * rin && f <= rout * rout)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
