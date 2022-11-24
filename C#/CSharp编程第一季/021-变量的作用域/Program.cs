using System;

namespace _021_变量的作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            // if while for
            // 局部
            int a = 10;

            Console.WriteLine(a);

            while (true) {
                int b = 10;
                Console.WriteLine(a);
            }

            //for (int j = 0; j < 10; j++)
            //{

            //}
            int j = 0;
            for (; j < 10; j++)
            {

            }

            Console.WriteLine(j);
        }
    }
}
