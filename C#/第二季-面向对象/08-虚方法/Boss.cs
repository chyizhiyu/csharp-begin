using System;
using System.Collections.Generic;
using System.Text;

namespace _08_虚方法
{
    class Boss:Enemy
    {
        public override void Move()
        {
            Console.WriteLine("Boss特有的移动方法");
        }

        public void BossSkill()
        {
            
            Console.WriteLine("Boss特有的技能");
        }

        public new void AI()
        {
            Console.WriteLine("Boss自己的AI");
        }
    }
}
