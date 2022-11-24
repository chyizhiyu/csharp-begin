using System;
using System.Collections.Generic;
using System.Text;

namespace _08_虚方法
{
    class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("敌人进行移动");
        }

        public void AI()
        {
            Console.WriteLine("敌人的AI");
        }
    }
}
