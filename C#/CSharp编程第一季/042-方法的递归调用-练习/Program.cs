using System;

namespace _042_方法的递归调用_练习
{
    class Program
    {
        static int  F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F(n - 1);
            return result;
        }

        static void Main(string[] args)
        {
            //10! = 10*9 ...   1

            //int result = 1;
            //for(int i = 1; i < 11; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine(result);

            //10!
            // f(n)=n*f(n-1)
            // 10! = 10*9!
            // f(1)=1 
            //Console.WriteLine(F(10));

            // 1+2!+3!+...+10!

            //int total = 0;
            //for(int i = 1; i < 11; i++)
            //{
            //    int temp = 1;
            //    for (int j = 1; j < i + 1; j ++) {
            //        temp = temp * j;
            //    }

            //    // i!
            //    total = total + temp;
            //}
            //Console.WriteLine(total);

            //1+2!+3!+...+10!
            //f(n)=1+2!+3!+...+n!
            //f(n)=f(n-1) + n!
            //f1(n)=n!
            //f2(n)=f2(n-1) + n!
            Console.WriteLine(F2(10));
        }

        static int F1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F1(n - 1);
            return result;
        }
        static int F2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F2(n - 1) + F1(n);
        }
    }
}
