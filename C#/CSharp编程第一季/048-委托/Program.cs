using System;

namespace _048_委托
{
    class Program
    {

        static double Multiply(double param1,double param2)//函数体
        {
            return param1 * param2;
        }

        static double Divide(double param1,double param2)
        {
            return param1 / param2;
        }

        static void Test()
        {
            Console.WriteLine("Test");
        }

        delegate double MyDelegate(double param1, double param2);

        delegate void MyDelegate2();

        static void Main(string[] args)
        {
            //Console.WriteLine(Multiply(2.3, 2));
            //Console.WriteLine(Divide(4.5, 3));

            MyDelegate delegate1;
            MyDelegate2 delegate2;

            delegate1 = Multiply;
            delegate1 = Divide;

            //delegate1 = Test;
            delegate2 = Test;

            Console.WriteLine(delegate1(2, 4));
            delegate2();
        }
    }
}
