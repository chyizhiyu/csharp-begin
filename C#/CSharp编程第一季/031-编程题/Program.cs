using System;

namespace _031_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //int pingNumber = 364;
            //int heNumber = 364;
            //while (pingNumber > 2)
            //{
            //    heNumber += pingNumber / 3;
            //    pingNumber=(pingNumber / 3) + (pingNumber % 3);
            //}
            //Console.Write("一共可以喝" + heNumber + "，剩下" + pingNumber);

            //string str = "Hello World";

            //char[] strArray = str.ToCharArray();
            //strArray[3] = 'a';

            //String str = Console.ReadLine();
            //char[] strArray = str.ToCharArray();
            //for(int i = 0; i < strArray.Length; i++)
            //{
            //    if( (strArray[i]>='a' &&strArray[i]<='z')||(strArray[i] >= 'A' && strArray[i] <= 'Z'))
            //    {
            //        strArray[i] = (char)(strArray[i] + 3);// 'a'+3    97+3  = 100  = 'd'
            //        if(strArray[i]>'z'&& strArray[i]< 'z' + 4)//xyz
            //        {
            //            strArray[i] = (char)(strArray[i] - 26);
            //        }
            //        if (strArray[i] > 'Z' && strArray[i] < 'Z' + 4)//XYZ
            //        {
            //            strArray[i] = (char)(strArray[i] - 26);
            //        }
            //    }
            //}

            //foreach(char temp in strArray)
            //{
            //    Console.Write(temp);
            //}

            //23 23 23 45 56 213 4 5 
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for(int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int min = intArray[0];//4
            int minIndex = 0;
            for(int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                    minIndex = i;
                }
            }
            int temp = intArray[0];
            intArray[0] = intArray[minIndex];
            intArray[minIndex] = temp;
            foreach(int t in intArray)
            {
                Console.Write(t + " ");
            }
        }
    }
}
