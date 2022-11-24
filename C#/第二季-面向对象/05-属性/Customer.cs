using System;
using System.Collections.Generic;
using System.Text;

namespace _05_属性
{
    class Customer
    {
        private string name;
        private string address;
        //private int age;
        private string createTime;

        //只读或者只写
        public string Name
        {
            get;set;
        }
        //自动创建private int age;成员
        public int Age { get; set; }


        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}
        //public int GetAge()
        //{
        //    return age;
        //}

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set //value参数
        //    {
        //        if (value < 0) return;
        //        age = value;
        //    }
        //}


        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄：" + Age);
            Console.WriteLine("创建时间：" + createTime);
        }
    }
}
