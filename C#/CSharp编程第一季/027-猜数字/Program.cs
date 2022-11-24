using System;

namespace _027_猜数字
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机数的生成Random
            Random rd = new Random();
            //伪随机 
            //Console.WriteLine(rd.Next(1, 10)); 

            int number = rd.Next(1, 101);

            while (true)
            {
                Console.WriteLine("猜猜我的数字是多少：");
                int numberUser = Convert.ToInt32(Console.ReadLine());
                if (numberUser > number)
                {
                    Console.WriteLine("你猜大了");
                }else if (numberUser < number)
                {
                    Console.WriteLine("你猜小了");
                }
                else
                {
                    Console.WriteLine("你猜中了");
                    break;
                }
            }

        }
    }
}
