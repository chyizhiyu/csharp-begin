using System;

namespace _010_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            // &&和   ||或    !非
            //bool a = (3 < 4) && (9 < 10);// true && false
            //bool a = true && true;// true && false

            //bool b = (3 < 2) && (9 < 7);

            ////bool c = !(4 < 7);
            //bool c = !true;//取反

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            int age = Convert.ToInt32(Console.ReadLine());

            bool isYoung = (age >= 18) && (age <= 60);

            Console.WriteLine(isYoung);
        }
    }
}
