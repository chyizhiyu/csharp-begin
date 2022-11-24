using System;

namespace _034_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //char temp = ' ';// 20x20
            //for(int i = 0; i < str.Length; i++)
            //{
            //    int count = 0;
            //    for(int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == str[i])
            //        {
            //            count++;
            //            if (count == 2)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    if (count==1)
            //    {
            //        temp = str[i];
            //        break;
            //    }
            //}
            //if(temp==' ')
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(temp);
            //}

            //时间  空间
            //string str = Console.ReadLine();
            //int[] countArray = new int[26];//计数，保存每个字符出现的个数
            //for(int i = 0; i < str.Length; i++)
            //{
            //    countArray[str[i] - 'a'] = countArray[str[i] - 'a'] + 1;
            //}

            //bool isFind = false;
            //char c = ' ';
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if(countArray[str[i] - 'a'] == 1)
            //    {
            //        isFind = true;
            //        c = str[i];
            //        break;
            //    }
            //}
            //if (isFind == false)
            //{
            //    Console.WriteLine("no");
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}


            //string str = Console.ReadLine();
            ////a-z  A-Z
            //int cha = 'A' - 'a';

            //for(int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        char c = (char)(str[i] + cha);
            //        Console.Write(c);
            //    }else if (str[i] >= 'A' && str[i] <= 'Z')
            //    {
            //        char c = (char)(str[i] - cha);
            //        Console.Write(c);
            //    }
            //    else
            //    {
            //        Console.Write(str[i]);
            //    }
            //}


            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int n = Convert.ToInt32(strArray[i]);
                intArray[i] = n;
            }

            int number = Convert.ToInt32(Console.ReadLine());
            int location = -1;
            for(int i = 0; i < intArray.Length; i++)
            {
                if (number == intArray[i])
                {
                    location = i + 1;
                    break;
                }
            }
            Console.WriteLine(location);
        }
    }
}
