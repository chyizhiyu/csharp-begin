using System;

namespace _06_值类型和引用类型的内存存储
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object

            //int a = 123;
            //float b = 34.5f;
            //bool c = true;

            //string name = "SiKi";

            //int[] array1 = new int[] { 23, 23, 11, 32, 4, 2435 };
            //string[] array2 = new string[] { "www", "sikiedu", "com" };

            //Customer c1 = new Customer("张三", "三里屯", 13, "2021");

            //string s1 = "张三";
            ////string s2 = "张三";
            //s1 = "李四";

            //Customer c1 = new Customer("张三", "三里屯", 13, "2021");
            //Customer c2 = new Customer("李四", "北京", 20, "2022");

            //c1.Show();
            //c1.name = "zhangsan";
            //c1.Show();

            //c2.Show();

            Customer c1 = new Customer("张三", "三里屯", 13, "2021");
            Customer c2 = c1;

            c1.Show();
            c2.Show();
            c2.name = "zhangsan";
            c2.Show();
            c1.Show();

            c1 = null;//空 空引用 空对象
            c2 = null;
        }
    }
}
