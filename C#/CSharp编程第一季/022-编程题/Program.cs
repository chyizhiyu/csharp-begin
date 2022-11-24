using System;

namespace _022_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = n;
            //while (n != 0)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //}
            //Console.WriteLine(sum);

            //int n = 0;
            //int sum = 0;
            //do
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //} while (n != 0);
            //Console.WriteLine(sum);

            //int n = Convert.ToInt32(Console.ReadLine());

            //double high = n;

            //for(int i = 0; i < 10; i++)
            //{
            //    high /= 2;
            //}
            //Console.WriteLine("第10次落地后会反弹的高度是:" + high);
            ////1 --- 2n
            ////2 --- n
            ////3 --- n/2
            ////10 --- d(9)/2
            //double distance = 2 * n;
            //double sum = n;
            //for (int i = 0; i < 9; i++) {
            //    distance /= 2;
            //    sum += distance;
            //}
            //Console.WriteLine("第10次落地后经过了多少米是:" + sum);


            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for(int i = 0; i < n; i++)
            //{
            //    result *= a; // 1 *a *a *a 
            //}
            //Console.WriteLine(result);

            // 6  1*2*3*4*5*6
            //int n = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for(int i = 1; i <= n; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);

            //int q = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int temp = 1;
            //int sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    // qn
            //    temp *= q;
            //    sum += temp;
            //}
            ////q 3  n = 3
            //// 1+ 3+ 9 +27
            //Console.WriteLine(sum);

            //int k = Convert.ToInt32(Console.ReadLine());
            ////n 1
            //double sn = 0;
            //int n = 0;
            //while (sn <= k)
            //{
            //    n++;
            //    sn += 1.0 / n;
            //}
            //Console.WriteLine(n);

            //double x = Convert.ToInt32(Console.ReadLine());

            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
            //    x *= 1.001;
            //}
            //Console.WriteLine(x);
            // R M Y
            //int r = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < y; i++)
            //{
            //    m = (int)(m * ((r / 100.0) + 1));
            //}
            //Console.WriteLine(m);

            //for(int i = 100; i <= 999; i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;
            //    if( i==ge*ge*ge+shi*shi*shi+bai*bai*bai)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int n = Convert.ToInt32(Console.ReadLine());
            //2325
            //5 232
            //2 23
            //3 2
            //2 0
            //while (n!=0) {
            //    int i=n% 10;
            //    Console.WriteLine(i);
            //    n = n / 10;
            //}

            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int cheng = 1;// 1 10 100 1000
            //while (n != 0)
            //{
            //    int i = n % 10;//i就是遍历各个位上的数字

            //    if (i != 0)
            //    {
            //        i *= cheng;// ge  1*
            //        sum += i;
            //        cheng *= 10;
            //    }


            //    n = n / 10;
            //}
            //Console.WriteLine(sum);

            //int n = Convert.ToInt32(Console.ReadLine());
            //标志位，标志是否达到了某个条件
            //bool yudao = false;// 默认还没有遇到第一个非0
            //while (n != 0)//从低位到高位遍历
            //{
            //    int i = n % 10;//23407800   i = 0 0 8 7 0 4 3 2
            //    //判断是否遇到了第一个非0数字
            //    //已经遇到了第一个非0数字
            //    //不需要去掉0了
            //    //还没有遇到第一个非0数字
            //    //去掉
            //    if (yudao==false)//还没有遇到第一个非0数字
            //    {
            //        if (i != 0)//i=8
            //        {
            //            Console.Write(i);
            //            yudao = true;
            //        }
            //    }
            //    else //i=7
            //    {
            //        Console.Write(i);
            //    }

            //    //if (i != 0)
            //    //{
            //    //    Console.Write(i);
            //    //}
            //    n = n / 10;
            //}

        }
    }
}
