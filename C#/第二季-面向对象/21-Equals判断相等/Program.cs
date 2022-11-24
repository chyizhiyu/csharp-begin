using System;

namespace _21_Equals判断相等
{
    class Program
    {
        static void Main(string[] args)
        {
            //equals
            //ToString Equals Object
            //int a = 12;
            //int b = 12;

            //Console.WriteLine(a.Equals(b));// a == b

            //string str1 = "siki";
            //string str2 = "siki";
            //Console.WriteLine(str1.Equals(str2));

            Student stu1 = new Student(18, "小芳");
            Student stu2 = new Student(18, "小芳");

            Console.WriteLine(stu1.Equals(stu2));
            Console.WriteLine(stu1 == stu2);


        }
    }
}
