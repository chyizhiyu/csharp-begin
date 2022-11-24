using System;

namespace _024_字符读取和编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert.ToInt32(Console.ReadLine());
            //数字类型 字符串
            //a 换行
            //char a = (char)Console.Read();
            //char b = (char)Console.Read();

            //Console.WriteLine("------");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //char c = (char)Console.Read();
            //Console.WriteLine(c);
            //char c ;// '0' --  55  '9'    -- 
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        //
            //        int number = c - '0';
            //        sum += number;
            //    }
            //} while (c != '@');
            //Console.Write(sum);

            //char c;// '0' --  55  '9'    -- 
            //int sum = 0;
            //do
            //{
            //    c = (char)Console.Read();
            //    if (c >= '0' && c <= '9')
            //    {
            //        //
            //        int number = c - '0';
            //        sum += number;
            //    }
            //    else if (c == '*')
            //    {
            //        sum += 500;
            //    }
            //} while (c != '#');
            //Console.Write(sum);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //String str = "";
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //        str += i + " ";
            //    }
            //}
            //Console.WriteLine(count);
            //Console.WriteLine(str);

            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
