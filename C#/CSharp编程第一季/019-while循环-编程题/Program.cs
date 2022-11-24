using System;

namespace _019_while循环_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            //int j = 0;
            //while (n != 1)
            //{
            //    //变换
            //    if (n % 2 == 1)
            //    {
            //        n = 3 * n + 1;
            //    }
            //    else
            //    {
            //        n /= 2;
            //    }
            //    j++;
            //    Console.WriteLine("变换后的值为：" + n);
            //}

            //Console.WriteLine("变换的次数为：" + j);

            //int number = 80000;
            //int year = 2006;
            //while( number<200000)
            //{
            //    number = (int)(number * 1.25);//增加了一年
            //    year++;
            //}
            //Console.WriteLine(year);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i < n + 1)
            //{
            //    //int year = Convert.ToInt32(Console.ReadLine());
            //    //sum += year;
            //    sum += Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}
            //double ave = 1.0*sum / n;
            //// 4.5342  100 int   453
            //ave = ((int)(ave * 100)) / 100.0;
            //Console.WriteLine(ave); 

            //Console.WriteLine(1);
            //Console.Write(2);
            //Console.Write(3);
            //Console.WriteLine(4);

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < n + 1)
            {
                Console.Write(i+" ");
                i++;
            }

        }
    }
}
