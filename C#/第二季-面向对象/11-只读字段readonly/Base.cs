using System;
using System.Collections.Generic;
using System.Text;

namespace _11_只读字段readonly
{
    class Base
    {

        public readonly int hp = 100;

        public Base()
        {

        }

        public Base(int hp)
        {
            this.hp = hp;
        }
    }
}
