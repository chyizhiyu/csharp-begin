using System;

namespace _002_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            // 生产环境 开发环境
            int[] myArr = { 1, 2, 3, 4 };
            

            try
            {
                int temp = myArr[4];
            }
            catch
            {
                //出现这个异常的时候，怎么处理
                Console.WriteLine("出现了数组下标越界的异常");
            }
            finally
            {
                Console.WriteLine("不管是否出现异常，都会执行");
            }

            Console.Write("23");

            
            
        }
    }
}
