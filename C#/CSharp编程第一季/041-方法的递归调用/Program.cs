using System;

namespace _041_方法的递归调用
{
    class Program
    {

        static void Test()
        {
            Console.WriteLine("test1");
            Test();
            Console.WriteLine("test2");
        }

        static int F(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }

            int res = F(n - 1) + F(n - 2);
            return res;
        }

        static void Main(string[] args)
        {
            //fn = fn1 + fn2  f0=2 f1=3
            //int n1 = 3;//f1
            //int n2 = 2;//f0
            //int n = 0;
            //for(int i = 2; i < 41; i++)//2~40
            //{
            //    n = n1 + n2;
            //    n2 = n1;
            //    n1 = n;
            //}
            //Console.WriteLine(n);

            //Test();
            Console.WriteLine(F(40));
        }
    }
}
