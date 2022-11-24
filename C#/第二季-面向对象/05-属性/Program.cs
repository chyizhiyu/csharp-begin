using System;

namespace _05_属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer lisi = new Customer();

            //lisi.SetAge(23);

            //Console.WriteLine(lisi.GetAge());
            lisi.Age = 1;

            Console.WriteLine(lisi.Age);

            lisi.Name = "sikiedu";
            Console.WriteLine(lisi.Name);

            int age = 12;

            var age2 = 45;
            age2 = 90;
            //age2 = "";

            var name = "siki";

        }


    }
}
