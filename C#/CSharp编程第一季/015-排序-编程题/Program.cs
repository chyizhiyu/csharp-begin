using System;

namespace _015_排序_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //// a b     b c       a  b
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //if (b > c)
            //{
            //    int temp = b;
            //    b = c;
            //    c = temp;
            //}
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //Console.WriteLine(a + " " + b + " " + c);

            //double m = Convert.ToDouble(Console.ReadLine());
            //int k = Convert.ToInt32(Console.ReadLine());

            //if (k == 0)
            //{
            //    int temp = (int)m;
            //    Console.WriteLine(temp);
            //}
            //else
            //{
            //    // 3.2543 + 0.05  =3.3043  *10  33.043  33 /10  3.3
            //    double temp = ((int)((m + 0.05) * 10)) / 10.0;
            //    Console.WriteLine(temp);
            //}
            
            char c = Convert.ToChar(Console.ReadLine());
            // a-z
            if( c>='a' && c<='z')
            {
                Console.WriteLine("你输入的是一个小写字母");
            }
            else
            {
                Console.WriteLine("你输入的不是一个小写字母");
            }
            //0-9  48-57  '0'-'0'  '1'-'0'

            //double res = (3 + 8) / 2.0;
            double res = (3 + 8)*1.0 / 2;
            
        }
    }
}
