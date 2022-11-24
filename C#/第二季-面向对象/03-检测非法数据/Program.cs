using System;

namespace _03_检测非法数据
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数字，每行一个");

            //string number1 = ;
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //string number2 = Console.ReadLine();


            int n1 = 0, n2 = 0;

            //try
            //{
            //    n1 = Convert.ToInt32(Console.ReadLine());
            //    n2 = Convert.ToInt32(Console.ReadLine());
            //}catch(FormatException e)
            //{
            //    Console.WriteLine("你输入的数据，不符合规则,请重新输入");
            //    n1 = Convert.ToInt32(Console.ReadLine());
            //    n2 = Convert.ToInt32(Console.ReadLine());
            //}

            while (true)
            {

                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("你输入的数据，不符合规则,请重新输入");
                }

            }

            Console.WriteLine(n1 + n2);
        }
    }
}
