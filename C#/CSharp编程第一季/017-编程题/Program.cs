using System;

namespace _017_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            // a b c d
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());

            //int max = a, min = a;
            //if (max < b)
            //{
            //    max = b;
            //}
            //if (max < c)
            //{
            //    max = c;
            //}
            //if (max < d)
            //{
            //    max = d;
            //}

            //if (min > b)
            //{
            //    min = b;
            //}
            //if (min > c)
            //{
            //    min = c;
            //}
            //if (min > d)
            //{
            //    min = d;
            //}

            //Console.WriteLine("最大值是{0},最小值是{1}.", max, min);

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int op = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            switch (op)
            {
                case 0:
                    res = a + b;
                    Console.WriteLine(res);
                    break;
                case 1:
                    res = a - b;
                    Console.WriteLine(res);
                    break;
                case 2:
                    res = a * b;
                    Console.WriteLine(res);
                    break;
                case 3:
                    double res2 = a*1.0 / b;
                    Console.WriteLine(res2);
                    break;

            }

        }
    }
}
