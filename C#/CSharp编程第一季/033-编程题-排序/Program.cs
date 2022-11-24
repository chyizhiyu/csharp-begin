using System;

namespace _033_编程题_排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            ////
            //Array.Sort(intArray);
            //foreach(int temp in intArray)
            //{
            //    Console.Write(temp + " ");
            //}


            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            ////获得一组数字
            ////19-19-18
            //for(int j = 0; j < intArray.Length - 1; j++)//进行length-1轮比较
            //{
            //    //进行比较 j=0 length-1
            //    // j=1 length-1-1
            //    // j=2 length-1-2
            //    //需要一个变量标志，记录当前轮次比较是否有发生交换
            //    bool isChange = false;
            //    for(int i = 0; i < intArray.Length - 1-j; i++)
            //    {
            //        //如果左边大于右边 ，就交换
            //        if (intArray[i] > intArray[i + 1])
            //        {
            //            int temp = intArray[i];
            //            intArray[i] = intArray[i + 1];
            //            intArray[i + 1] = temp;
            //            isChange = true;
            //        }
            //    }
            //    if (isChange == false)
            //    {
            //        break;
            //    }
            //}

            //foreach (int temp in intArray)
            //{
            //    Console.Write(temp + " ");
            //}

            //string str = Console.ReadLine();

            //// 判断 数字 字母 _
            //// 数字开头
            //bool isRight = true;
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if( (str[i]<'0' || str[i]>'9') && (str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z') && (str[i] != '_'))
            //    {
            //        isRight = false;
            //        break;
            //    }
            //}
            //if(str[0] >= '0' && str[0] <= '9')
            //{
            //    isRight = false;
            //}
            //if (isRight)
            //{
            //    Console.WriteLine("是合法标识符");
            //}
            //else
            //{
            //    Console.WriteLine("不是合法标识符");
            //}

            //string str = Console.ReadLine();
            //// 8  8/2=4  0-3
            //// 7  7/2=3  0-2
            //// 7
            //// 0 - 6  1-5  2-4    i ~ length-1-i
            //bool isHui = true;
            //for(int i = 0; i < str.Length / 2; i++)
            //{
            //    // i  length-1-i
            //    if(str[i]!=str[str.Length - 1 - i])
            //    {
            //        isHui = false;
            //        break;
            //    }
            //}
            //if (isHui)
            //{
            //    Console.WriteLine("是回文串");
            //}
            //else
            //{
            //    Console.WriteLine("不是回文串");
            //}


            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    int number = Convert.ToInt32(strArray[i]);
            //    intArray[i] = number;
            //}
            //int maxDays = 1;//记录最高 气温连续升高的天数
            //int count = 1;//记录气温连续升高的天数
            //for(int i = 0; i < intArray.Length - 1; i++)
            //{
            //    if (intArray[i] < intArray[i + 1])
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        if (count > maxDays)
            //        {
            //            maxDays = count;
            //        }
            //        count = 1;
            //    }
            //}
            //if (count > maxDays)
            //{
            //    maxDays = count;
            //}
            //Console.WriteLine("气温连续升高的最长天数" + maxDays);

            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }

            int max1 = 0;int max2 = 0;

            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > max1)
                {
                    max2 = max1;
                    max1 = intArray[i];
                }
                else
                {
                    if (intArray[i] > max2)
                    {
                        max2 = intArray[i];
                    }
                }
            }
            Console.WriteLine("第一大值是" + max1 + " 第二大值是" + max2);

        }
    }
}
