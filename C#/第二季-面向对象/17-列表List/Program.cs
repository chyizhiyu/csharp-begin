using System;
using System.Collections.Generic;

namespace _17_列表List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //List<int> list = new List<int>() { 321,653,832 };
            ////List<string> list = new List<string>();

            //list.Add(900);
            //list.Add(6732);

            //list[3] = 9;

            ////Console.WriteLine(list[3]);

            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //List<int> list = new List<int>(50);

            //Console.WriteLine(list.Count+":"+ list.Capacity);

            //list.Add(12);
            //Console.WriteLine(list.Count + ":" + list.Capacity);
            //list.Add(12);
            //list.Add(12);
            //list.Add(12);
            //Console.WriteLine(list.Count + ":" + list.Capacity);
            //list.Add(12);
            //Console.WriteLine(list.Count + ":" + list.Capacity);

            List<int> list = new List<int>(50);
            list.Add(34);list.Add(234);
            foreach(int temp in list)
            {
                Console.WriteLine(temp);
            }

        }
    }
}
