using System;

namespace _13_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plane p = new Plane();
            //p.Fly();
            //p.FlyAttack();

            //多态
            IFly fly;
            fly = new Plane();
            fly.Fly();
            fly.FlyAttack();

            fly = new Bird();
            fly.Fly();
            fly.FlyAttack();
        }
    }
}
