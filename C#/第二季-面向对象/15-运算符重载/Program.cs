using System;

namespace _15_运算符重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ - * / ==
            //函数重载

            //Student s1 = new Student(20, "张三", 12803);
            //Student s2 = new Student(20, "张三", 12903);

            ////Student s3 = s1;

            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1 != s2);
            //Console.WriteLine(s1 == s3);

            Class2 o = new Class2(); o.MethodA();
        }
    }

    abstract class BaseClass
    {
        public virtual void MethodA() { Console.WriteLine("BaseClass"); }
        public virtual void MethodB() { }
    }
    class Class1 : BaseClass
    {
        public void MethodA() { Console.WriteLine("Class1"); }
        public override void MethodB() { }
    }
    class Class2 : Class1
    {
        new public void MethodB() { }
    }
}
