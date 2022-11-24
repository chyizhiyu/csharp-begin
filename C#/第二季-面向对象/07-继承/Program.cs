using System;

namespace _07_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass bc = new BaseClass();
            //bc.data1 = 12;
            //bc.data2 = "2332324dfsdg";
            //Console.WriteLine(bc.data2);
            //bc.Function1();
            //bc.Function2();

            //DrivedClass1 dc1 = new DrivedClass1();
            //dc1.Function1();
            //dc1.Function2();
            //dc1.data1 = 100;
            //Console.WriteLine(dc1.data1);

            //DrivedClass2 dc2 = new DrivedClass2();
            //dc2.Function1();

            Boss boss1 = new Boss(100,100000,20);
            boss1.Print();
        }
    }
}
