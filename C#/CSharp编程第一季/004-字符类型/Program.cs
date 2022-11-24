using System;

namespace _004_字符类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'a';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //97 a
            //int a = 97;
            //char b = (char)a;//强制类型转换 强塞
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //char a = '1';
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //char a = '\n';
            //char b = '\\';
            //char c = '\"';
            //char d = '\t';
            //char e = '\'';

            //Console.WriteLine("c:\\a" +
            //    "\\b\\c");
            //Console.WriteLine(@"c:\a\b\c");
            //Console.WriteLine(@"c:\\a\\b\\c");

            //            string str = @"www.sikiedu.com ""
            //sdfds
            //sdf
            //sikisdfdsf";
            //            Console.WriteLine(str);

            //string str = "123" + "456";
            //string str2 = str + "www";
            //Console.WriteLine("www"+123);

            //怎么读取数据 输入数据
            //String str = Console.ReadLine();//"12" 12
            //Console.WriteLine(str + "-");
            //1、类型一致  2、右边的值所需要的容器大小 小于等于左边的容器
            //int a = Console.ReadLine();

            String str = Console.ReadLine();//"12" 12
            int strInt = Convert.ToInt32(str);//"12" 12  "df"

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(strInt + "-"+a);
        }
    }
}
