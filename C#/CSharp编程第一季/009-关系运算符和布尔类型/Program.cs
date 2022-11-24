using System;

namespace _009_关系运算符和布尔类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool a = true;//是的  真的  满足条件    1
            //bool b = false;//不是 假的  不满足条件  0
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            bool a = 45 == 67;
            bool b = 45 < 67;
            bool c = 45 <= 45;
            bool d = 45 > 67;
            bool e = 45 >= 67;
            bool f = 45 != 67;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
