using System;
using System.Collections.Generic;
using System.Text;

namespace _07_继承
{
    class Boss:Enemy
    {
        private int attack;

        private int hp;

        public Boss(int attack,int hp,int speed)
        {
            this.attack = attack;
            //this.hp = hp;
            //this.speed = speed;
            base.hp = hp;
            base.speed = speed;
            
        }

        public void Skill()
        {
            Console.WriteLine("Boss Skill");
        }

        public void Print()
        {
            Console.WriteLine("HP:" + hp);
            Console.WriteLine("Base.HP:" + base.hp);
            Console.WriteLine("Speed:" + speed);
            Console.WriteLine("Attack:" + attack);
        }
    }
}
