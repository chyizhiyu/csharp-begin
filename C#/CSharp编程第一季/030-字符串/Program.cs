using System;

namespace _030_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Micheal";
            //name = "Micheal" + " 123";
            //name = "" + 45;// "45"
            //Console.Write(name.Length);
            //Console.Write(name[3]);
            //for(int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //for(int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}


            string name = "xiaoming,zhangsan,xiaohong";
            // name.methodName();
            //string str2 = name.ToLower();
            //Console.WriteLine(name + "-" + str2);

            //string str3 = name.ToUpper(); 
            //Console.WriteLine(name + "-" + str3);

            //string str4 = name.Trim();
            //Console.WriteLine(name + "-" + str4);

            //string str5 = name.TrimStart();
            //Console.WriteLine(name + "-" + str5 + "|");

            //string str6 = name.TrimEnd();
            //Console.WriteLine(name + "-" + str6 + "|");

            string[] strArray = name.Split(",");
            foreach(string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
