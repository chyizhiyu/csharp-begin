using System;
using System.Collections.Generic;
using System.Text;

namespace _12_静态_static
{
    static class Test
    {
        //public int hp;
        public static int count;

        //静态函数只能使用 静态数据
        public static void Move()
        {
            Console.WriteLine(count);
            Console.WriteLine("移动");
        }

    }
}
