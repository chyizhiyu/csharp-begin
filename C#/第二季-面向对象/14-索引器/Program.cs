using System;

namespace _14_索引器
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] array = { 34, 567, 432, 4, 32 };

            //array[1] = 100;

            //Console.WriteLine(array[1]);
            //Test t = new Test();

            ////t[9] = 200;
            //Console.WriteLine(t[9]);

            //Test t = new Test();
            //t[0] = "张三";
            //t[1] = "李四";

            //Console.WriteLine(t[0]);
            //Console.WriteLine(t[1]);

            //string[] name = new string[10];
            //name[0] = "sdf";
            //name[1] = "987";

            Week w = new Week();
            //Console.WriteLine(w.GetDay("Thurs"));
            Console.WriteLine(w["Sat"]);

        }
    }
}
