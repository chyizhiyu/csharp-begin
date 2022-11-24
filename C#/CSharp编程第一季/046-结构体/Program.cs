using System;

namespace _046_结构体
{
    class Program
    {

        struct StudentInfo
        {
            public int age;
            public string name;
            public int grade;
            public int id;
            public bool gender;//true false
        }

        struct Position
        {
            public double x;
            public double y;
            public double z;

            public void PrintPosition()
            {
                Console.WriteLine(x + "," + y + "," + z);
            }
        }

        static void PrintPosition(Position p)
        {
            Console.WriteLine(p.x + "," + p.y + "," + p.z);
        }

        struct Name
        {
            public string firstName;
            public string lastName;

            public string FullName()
            {
                return firstName +" "+ lastName;
            }
        }

        static void Main(string[] args)
        {
            int student1Age = 10;
            string student1Name = "siki";
            int student1Grade = 2;
            int student1StudyID = 10213023;

            int student2Age = 20;
            string student2Name = "micheal";
            int student2Grade = 1;
            int student2StudyID = 10223023;

            int student3Age = 30;
            string student3Name = "micheal";
            int student3Grade = 1;
            int student3StudyID = 10223023;

            StudentInfo student1;
            student1.age = 10;
            student1.name = "小明";
            student1.grade = 2;
            student1.id = 10102103;

            //Console.WriteLine(student1.name);

            StudentInfo[] students = new StudentInfo[10];
            students[0].age = 30;

            Console.WriteLine(students[0].age);

            int[] stuAge = new int[10];
            string[] stuName = new string[10];

            Position p1;
            p1.x = 23.3;
            p1.y = 3.4;
            p1.z = 1;

            //PrintPosition(p1);

            p1.PrintPosition();

            Position p2;
            p2.x = 1;
            p2.y = 2;
            p2.z = 3;
            p2.PrintPosition();

            Name name;
            name.firstName = "三";
            name.lastName = "张";

            Console.WriteLine("My name is " + name.FullName()+".");

            Name name2;
            name2.firstName = "Steven";
            name2.lastName = "Jobs";
            Console.WriteLine("My name is " + name2.FullName());

        }
    }
}
