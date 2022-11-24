using System;

namespace _036_函数
{
    class Program
    {
        //方法的定义                 //形参 形式参数
        static bool VerifyUsername(string username)//参数
        {
            Console.WriteLine("校验逻辑修改");
            Console.WriteLine("校验逻辑修改2");
            Console.WriteLine("校验用户名"+username);

            return true;
        }
        //主函数-入口函数 --   主方法 入口方法
        //  a + b
        static void Add1() {
            int result = 3 + 4;
        }
        static void Add2(int a,int b)
        {
            int result = a + b;
        }
        //static 静态-修饰符
        static int Add3(int a,int b)
        {
            int result = a + b;
            return result;//break; 方法返回了之后，表示这个方法结束了，后续代码就不执行了
            Console.WriteLine("123");
        }
        static void Main(string[] args)
        {
            Add1();

            Add2(10, 12);

            int res = Add3(23, 23);
            Console.WriteLine(res);

            //100-50
            //方法的调用
            //某个字符串     实参，实际参数
            //bool result = VerifyUsername("siki");
            //Console.WriteLine(result);




            ////Console.WriteLine("校验逻辑修改");
            ////Console.WriteLine("校验用户名");
            //VerifyUsername("sikiedu");



            ////Console.WriteLine("校验逻辑修改");
            ////Console.WriteLine("校验用户名");
            //VerifyUsername("micheal");
        }
    }
}
