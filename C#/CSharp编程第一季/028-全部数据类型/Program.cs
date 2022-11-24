using System;

namespace _028_全部数据类型
{
    class Program
    {
        
        static void Main(string[] args)
        {



            //byte int long
            //sbyte a = 100;
            //sbyte b = -100;

            //int c = 2100000000;

            //long d = 1234567891234567891;

            //byte e = 30;

            ////c = a;

            ////a = (sbyte)c;
            ////Console.Write(a);

            ////a = e;
            ////e = a;

            //float f = 4.5f;

            //f = 2123456789;
            //Console.WriteLine(f);

            byte a = 32;

            int b = 200;

            //b = a;// 隐式转换

            //a = b;//显示转换 &
            Console.Write(a);

            int i = Convert.ToInt32("234");
            double j = Convert.ToDouble("4.5");

            //
            //string s = 123 + "";//"123"
            string s2 = Convert.ToString(123);//"123"
            //8bit 8位 1位只能存储一个0或1
        }
    }
}
