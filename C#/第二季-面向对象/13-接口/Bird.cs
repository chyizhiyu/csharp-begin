﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _13_接口
{
    class Bird : IFly
    {
        public void Fly()
        {
            Console.WriteLine("小鸟在空中飞");
        }

        public void FlyAttack()
        {
            Console.WriteLine("小鸟在空中攻击");
        }
    }
}
