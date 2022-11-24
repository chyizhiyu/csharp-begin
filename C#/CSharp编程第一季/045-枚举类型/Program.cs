using System;

namespace _045_枚举类型
{
    class Program
    {
        enum RoleType //枚举类型的名字
        {
            Mage,Archer, Assassin,Tank,Support,Warrior  //枚举类型的值
        }
        static void Main(string[] args)
        {
            //函数 - 定义 使用
            //1法师（Mage）、2射⼿（Archer）、3刺客（Assassin）、4坦克 （Tank）、5辅助（Support）、6战⼠（Warrior）

            //int roleType = 4;

            //roleType = 3;

            //int long string

            //RoleType roleType = RoleType.Tank;

            //if (roleType == RoleType.Archer)
            //{

            //}

            GameState gameState = GameState.Menu;

            gameState = GameState.Running;

            if (gameState == GameState.Menu)
            {

            }
            Console.WriteLine(gameState);

            Week day = Week.Mon;
            day = Week.Tue;

            //int i = 1;//0-6 1-7
            int number = (int)day;
            Console.WriteLine(day);
            Console.WriteLine(number);

        }
        //菜单、游戏中、暂停、失败、成功
        enum GameState
        {
            Menu,Running,Pause,Fail,Success
        }
        //Sun, Mon, tue, Wed, thu, Fri, Sat
        enum Week
        {
            Sun, Mon, Tue=10, Wed, Thu, Fri=100, Sat
        }
    }
}
