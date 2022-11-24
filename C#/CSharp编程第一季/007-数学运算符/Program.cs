using System;

namespace _007_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 23 + 23;
            //int b = 2 - 10;
            //int c = 4 * 23;
            //int d = 45 / 10;
            //int e = 45 % 10;

            //double f = 45 / 10.0;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);

            //int num = 39;
            //int ge = num % 10;
            //int shi = num / 10;
            //Console.WriteLine("个位是{0},十位数是{1}",ge, shi);

            int a = 0;
            a += 10;//a = a+10;
            Console.WriteLine(a);
            a -= 5;//5
            Console.WriteLine(a);
            a *= 3;//15
            Console.WriteLine(a);
            a /= 6;//2
            Console.WriteLine(a);
            a %= 2;//0
            Console.WriteLine(a);
        }
    }
}
