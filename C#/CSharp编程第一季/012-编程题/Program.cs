using System;

namespace _012_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            // 123 
            // 123/10=12
            //int number = Convert.ToInt32(Console.ReadLine());

            //int ge = number % 10;
            //int shi = (number / 10) %10;
            //int bai = number / 100;
            //Console.WriteLine(""+ge + shi + bai);

            //23452
            //int number = Convert.ToInt32(Console.ReadLine());
            //int shi = (number / 10)%10;
            //int qian = (number / 1000) % 10;
            //int numberNew = qian * 10 + shi;
            //char c = (char)numberNew;
            //Console.WriteLine(c);

            //int a = 3; 
            //int b = a++ + a++;
            //// 3 + a++ //a=4
            //// 3 + 4 // a = 5
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            //int a = 3; 
            //int b = a++ + (++a);
            //// 3   +(++a)         //a = 4
            //// 3+ 5                     a =5
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            int mathScore = Convert.ToInt32(Console.ReadLine());
            int englishScore = Convert.ToInt32(Console.ReadLine());
            bool isGetAward = mathScore >= 90 && englishScore >= 90;
            Console.WriteLine(isGetAward);
        }
    }
}
