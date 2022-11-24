using System;
using System.Collections.Generic;

namespace _18_列表的常用操作
{
    class Program
    {
        static void ShowList(List<int> list)
        {
            foreach (int temp in list)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 56, 23, 894, 32, 5623, 32,4573 };

            //Console.WriteLine(list.Capacity);
            //list.Add(800);

            //Console.WriteLine(list[2]);

            //list.Insert(3, 800);


            //list.Remove(32);
            //ShowList(list);

            //list.RemoveAt(2);
            //ShowList(list);

            //增加  删除 改 查

            //Console.WriteLine(list.IndexOf(320));
            //Console.WriteLine(list.LastIndexOf(32));

            list.Sort();
            ShowList(list);

        }
    }
}
