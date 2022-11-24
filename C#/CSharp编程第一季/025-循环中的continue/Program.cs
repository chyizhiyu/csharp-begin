using System;

namespace _025_循环中的continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //continue;
            //break;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;//中止当前循环，继续下次循环
                    //break;
                }
                Console.WriteLine(i);
            }

        }
    }
}
