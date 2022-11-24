using System;

namespace _01_调试和错误排查_Debug_
{
    class Program
    {
        static int Add(int a,int b)
        {
            int result = a + b;
            //Console.WriteLine("Method:" + result);
            return result;
        }
        static void Main(string[] args)
        {
            int temp = 100;
            int result = Add(40, 20);

            int a = 123;
            int b = 456;

            Console.WriteLine(a);

            int c = 789;

            Console.WriteLine(b);

            Console.WriteLine(result);
        }
    }
}
