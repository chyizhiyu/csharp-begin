using System;
using System.Threading.Channels;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork0605 homeWork = new HomeWork0605();
            //homeWork.Work1();
            //homeWork.Work2();
            //homeWork.Work3();
            homeWork.Work4();
            
        }
    }
    class HomeWork0605
    {
        public void Work1()
        {
            //提示用户输入密码，如果密码是“888888”则提示正确，否则提示错误。
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            if (password == "888888")
            {
                Console.WriteLine("密码正确！");
            }
            else
            {
                Console.WriteLine("密码错误！");
            }
        }

        public void Work2()
        {
            //提示用户输入密码，如果密码是“888888”则提示正确，否则要求再输入一次，如果密码是“888888”则提示正确，否则提示错误。
            Console.WriteLine("请输入密码：");
            string password = Console.ReadLine();
            if (password =="888888")
            {
                Console.WriteLine("密码正确！");
            }
            else
            {
                Console.WriteLine("请再次输入密码：");
                password = Console.ReadLine();
                if (password == "888888")
                {
                    Console.WriteLine("密码正确！");
                }
                else
                {
                    Console.WriteLine("密码错误！");
                }
            }
        }

        public void Work3()
        {
            //提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于10岁，则告知不允许查看，如果大于等于10岁，则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户可以查看，否则提示不可以查看。
            Console.WriteLine("请输入年龄：");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("可以查看！");
            }
            else if (age < 10)
            {
                Console.WriteLine("不允许查看！");
            }
            else
            {
                Console.WriteLine("是否继续查看（yes、no）：");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("可以查看！");
                }
                else
                {
                    Console.WriteLine("不可以查看！");
                }
            }
        }

        public void Work4()
        {
            Console.WriteLine("请输入一个整数：");
            int i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("再次输入一个整数: ");
            int i2 = int.Parse(Console.ReadLine());
            if (i1 > 0 && i2 > 0)
            {
                Console.WriteLine( ++i1 + i2);
            }

            else if (i1 <0 && i2 < 0)
            {
                i1 -= 10;
                Console.WriteLine( i1 * i2);
            }
            
            else if(i1 == 0 || i2 == 0)
            {
                Console.WriteLine( "数据有错误");
            }
            else
            {
                Console.WriteLine( i1 * i2);
            }
        }
    }
}