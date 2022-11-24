using System;

namespace _023_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int tempN = n;
            int number = 0;
            // 3617
            // 7 1 6 3
            // 7*10 10
            //71*10  710
            //7160
            // 7163
            while (tempN != 0)//从低位到高位
            {
                int i = tempN % 10;
                number *= 10;
                number += i;

                tempN = tempN / 10;
            }
            
            if (number == n)
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
