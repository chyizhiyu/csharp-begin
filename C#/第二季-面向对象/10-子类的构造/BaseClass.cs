using System;
using System.Collections.Generic;
using System.Text;

namespace _10_子类的构造
{
    class BaseClass
    {

        private int hp;
        private int speed=900;

        public BaseClass(int hp, int speed)
        {
            this.hp = hp;
            this.speed = speed;
        }

        public BaseClass()
        {
            Console.WriteLine("构造函数：BaseClass");
        }

    }
}
