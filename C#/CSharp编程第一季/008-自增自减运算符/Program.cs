using System;

namespace _008_自增自减运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //a++;//
            //++a;
            //int b = a++;//先赋值再自增   先自增再赋值
            //int b = ++a;
            //Console.WriteLine(a+":"+b);
            Console.WriteLine(++a);
            Console.WriteLine(a);
        }
    }
}
