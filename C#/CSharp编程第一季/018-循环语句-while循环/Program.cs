using System;

namespace _018_循环语句_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write WriteLine
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //1-10
            // true false

            //while (true)
            //{
            //    Console.WriteLine("while循环体");
            //}

            //1-10

            //int i = 1;
            //while (true)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //while (i<11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            ////i = 11
            //Console.WriteLine("while后"+ i);

            ////当while不满足条件的时候，就跳出循环，执行后面的代码
            //Console.WriteLine("while后");

            //
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //1-10
            //int i = 0;
            //while (i < 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //while (i < 1001)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int HP = 100;
            //while (HP>0)
            //{
            //    HP -= 3;
            //    Console.WriteLine("HP"+HP);
            //}

            //1-100
            //100-1
            //int i = 100;
            //while (i>0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //i = 0
            // 1 + 2 + 3 。。。n
            //1 + 2 +3 _   ... 100



            //int i = 1;
            //int sum = 0;
            //while (i < 101)
            //{
            //    // 1  ~ 100 sum = sum + i
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //int n = Convert.ToInt32(Console.ReadLine());

            //遍历 1-100
            //int i = 1;
            //int sum = 0;
            //while (i < n+1)
            //{
            //    // 1  ~ 100 sum = sum + i
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //int i = 1;
            //while (i < 101)
            //{
            //    // 1 ~ 100
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            // 10 15
            //int i = 10;
            //while (i < 16)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int i = n1;
            while (i < n2 + 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
