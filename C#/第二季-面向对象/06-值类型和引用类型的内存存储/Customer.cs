using System;
using System.Collections.Generic;
using System.Text;

namespace _06_值类型和引用类型的内存存储
{
    class Customer
    {
        public string name;
        public string address;
        public int age;
        public string createTime;

        public Customer(string name, string address, int age, string createTime)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.createTime = createTime;
        }

        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("创建时间：" + createTime);
        }
    }
}
