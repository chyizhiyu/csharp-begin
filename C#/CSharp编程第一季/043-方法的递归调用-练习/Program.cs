using System;

namespace _043_方法的递归调用_练习
{
    class Program
    {
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F(n - 1) + n*n;
        }
        static void Main(string[] args)
        {

            //f(n)=1 + 2 +..  n
            //f(n)= f(n-1)+n
            //f(1)=1
            //int k = 1;
            //int result = 0;
            //while (true)
            //{
            //    result += k * k;
            //    if (result >= 2000)
            //    {
            //        break;
            //    }
            //    k++;
            //}
            //Console.WriteLine(k - 1);

            int i = 1;
            while (true)
            {
                if (F(i) >= 2000)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i - 1);


        }
    }
}
