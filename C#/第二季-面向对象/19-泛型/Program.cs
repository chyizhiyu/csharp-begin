using System;

namespace _19_泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassA a = new ClassA(34, 12);
            //Console.WriteLine(a.GetSum());
            //ClassA<int> a = new ClassA<int>(45, 65);
            //Console.WriteLine(a.GetSum());
            //ClassA<double> a = new ClassA<double>(2.3, 6.3);
            //Console.WriteLine(a.GetSum());
            // dynamic 
            //类的对象 toString

            //Program p = new Program();
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p);

            //Program p1 = new Program();
            //Program p2 = new Program();
            //string str = p1.ToString() + p2.ToString();

            //Student s = new Student(30, "小凡");
            //Console.WriteLine(s);

            //Console.WriteLine(GetSum(34, 56));  
            //Console.WriteLine(GetSum<int>(23, 45));
            //Console.WriteLine(GetSum<int>(23, 45));

            Console.WriteLine("234");
            int result = GetSum<int>(45, 12);
            Console.WriteLine(result);
        }

        public static T GetSum<T>(T a,T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return (T)(num1 + num2);
        }
    }

    class ClassA<T> //Type int string double
    {// MyClass
        private T a;
        private T b;
        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum()
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return (T)result;
        }
    }
    //class ClassADouble
    //{
    //    private double a;
    //    private double b;
    //    public ClassADouble(double a, double b)
    //    {
    //        this.a = a;
    //        this.b = b;
    //    }
    //    public double GetSum()
    //    {
    //        return a + b;
    //    }
    //}

}
