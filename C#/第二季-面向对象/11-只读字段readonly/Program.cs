using System;

namespace _11_只读字段readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(200);
            Console.WriteLine(b.hp);

            b.hp = 300;
        }
    }
}
