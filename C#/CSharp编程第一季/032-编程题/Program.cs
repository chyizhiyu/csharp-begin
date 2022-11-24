using System;

namespace _032_编程题
{
    class Program
    {
        static void Main(string[] args)
        {
            //得到一个有序的数组
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            int x = Convert.ToInt32(Console.ReadLine());
            int m = intArray.Length - 1; 
            //bool find = false;//是否找到满足条件的索引位置，这个索引位置满足条件 m<=x<=m+1
            for (int i = 0; i < intArray.Length-1; i++)
            {
                if(x>=intArray[i] && x <= intArray[i + 1])
                {
                    m = i;
                    //find = true;
                    break;
                }
            }
            if (x < intArray[0])
            {
                m = -1;
            }
            //if (find == false)
            //{
            //    m = intArray.Length - 1;
            //}
            //
            int[] intArrayNew = new int[intArray.Length + 1];
            //0-m = 0~-1    
            for (int i = 0; i < m+1; i++)
            {
                intArrayNew[i] = intArray[i];
            }
            intArrayNew[m + 1] = x;
            //m+1~length-1
            for(int i = m + 1; i < intArray.Length; i++)
            {
                intArrayNew[i+1] = intArray[i];
            }
            foreach(int temp in intArrayNew)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
