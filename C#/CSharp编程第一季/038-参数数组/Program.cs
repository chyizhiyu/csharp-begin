using System;

namespace _038_参数数组
{
    class Program
    {
        static int Add1(int a,int b)
        {
            return a + b;
        }
        static int Add2(int[] array)
        {
            int sum = 0;
            foreach (int temp in array)
            {
                sum += temp;
            }
            return sum;
        }
        static int Add3(params int[] array)//可以传递任意个个数的参数
        {
            int sum = 0;
            foreach (int temp in array)
            {
                sum += temp;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            int sum1 = Add2(new int[] { 2, 4, 8 });
            Console.WriteLine(sum1);

            int[] array2 = { 6, 8, 9 };
            int sum2 = Add2(array2);
            Console.WriteLine(sum2);

            int sum3 = Add3(6, 8, 1);
            Console.WriteLine(sum3);


            int sum4 = Add3( 1,3,5,7,9,2);
            Console.WriteLine(sum4);



        }
    }
}
