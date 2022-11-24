using System;

namespace _16_结构体和类的不同
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student(18, "小芳");
            //Student stu2 = new Student(25, "小刚");

            //stu2 = stu1;

            //stu1.age = 30;
            //stu1.name = "小燕";
            //Console.WriteLine(stu2.age);
            //Console.WriteLine(stu2.name);

            //StudentSt stu1 = new StudentSt(18, "小芳");
            //StudentSt stu2 = stu1;
            //
            //stu2.age = stu1.age;
            //stu2.name = stu1.name;
            //stu1.name = "小燕";
            //stu1.age = 30;

            //Console.WriteLine(stu2.age);
            //Console.WriteLine(stu2.name);

            StudentSt stu1 = new StudentSt(18, "小芳");
            StudentSt stu2 = new StudentSt(25, "小刚");

            stu2 = stu1;

            stu1.age = 30;
            stu1.name = "小燕";

            Console.WriteLine(stu2.age);
            Console.WriteLine(stu2.name);
        }
    }

    struct StudentSt
    {
        public int age;
        public string name;

        public StudentSt(int age,string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
