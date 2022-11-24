using System;

namespace _035_模拟法_张三的零花钱
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] budget = new int[strArray.Length];
            for (int j = 0; j < strArray.Length; j++)
            {
                int n = Convert.ToInt32(strArray[j]);
                budget[j] = n;
            }
            int self = 0;
            int mom = 0;
            int i = 0;
            int tmp = 0;

            for (i = 0; i < 12; i++)//0-11  i+1
            {
                //本月一共有多少300+self
                //预算budget[i]
                tmp = 300 + self - budget[i];//剩余的钱  280/100 = 2*100 =200
                if (tmp < 0)
                {
                    //i+1
                    break;
                }
                //整百的
                mom += (tmp / 100)*100;
                self = tmp % 100;
            }
            //
            if (tmp < 0)
            {
                Console.WriteLine("-" + (i + 1));
            }
            else
            {
                self = self + (int)(mom * 1.2);
                Console.WriteLine(self);
            }

        }
    }
}
