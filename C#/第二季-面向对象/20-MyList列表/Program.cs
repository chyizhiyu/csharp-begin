using System;
using System.Collections.Generic;

namespace _20_MyList列表
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> list = new MyList<int>();

            //Console.WriteLine(list.Capacity);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(4);
            //Console.WriteLine(list.Count);

            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}

            //int temp1 = list[10];
            //int temp2 = list[-1];

            //List<int> l = new List<int>();
            //int temp = l[-1];

            list.Insert(2, 100);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            list.RemoveAt(3);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(list.IndexOf(4));
            Console.WriteLine(list.LastIndexOf(4));
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            Program p1 = new Program();
            Program p2 = new Program();
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p1.Equals(p2));

        }
        public override int GetHashCode()
        {
            return 100;
        }

    }
}
