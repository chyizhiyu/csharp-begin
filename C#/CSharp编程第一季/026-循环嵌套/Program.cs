using System;

namespace _026_循环嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 4; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");// i=0  j=0 ~ 9  i=1
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int n = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i < n+1; i++)
            //{
            //    //i=1   1  i=2  2   i
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i < n + 1; i++)
            //{
            //    //行好-1个*
            //    for(int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //for(int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int n = Convert.ToInt32(Console.ReadLine());

            //// n ~ 1
            //for(int i = n; i > 0; i--)
            //{
            //    for(int j = 0; j < i-1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            //int n = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    for(int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    // n-i个空格  i个*
            //    for(int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= n; i++)
            //{
            //    //n-i   2*i-1
            //    for(int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    //n-i   2*i-1
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////n-1总行数
            //for(int i = 1; i <= n - 1; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //*
            //    //n-1-i+1 = n-i   *2 -1
            //    int countStar = (n - i) * 2 - 1;
            //    for (int j = 0; j < countStar; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i <= 9; i++)
            //{
            //    //i 右乘数  左乘数1-i
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}x{1}={2} ", j, i, i * j);
            //    }
            //    Console.WriteLine();
            //}

            // x y z公鸡1-33 母鸡1-20 小鸡1-50
            //for(int x = 1; x <= 100 / 3; x++)
            //{
            //    for(int y = 1; y < 100 / 5; y++)
            //    {
            //        for(int z = 1; z < 100 / 2; z++)
            //        {
            //            //是否花了100文
            //            if((x * 3 + y * 5 + z * 2) == 100)
            //            {
            //                Console.WriteLine("公鸡{0}，母鸡{1},小鸡{2}", x, y, z);
            //            }
            //        }
            //    }
            //}

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            for(int i = min; i > 0; i--)
            {
                if(num1%i==0 && num2 % i == 0)
                {
                    Console.WriteLine("最大公约数" + i);
                    break;
                }
            }
        }
    }
}
