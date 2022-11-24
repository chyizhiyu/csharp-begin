using System;

namespace _039_编程题
{
    class Program
    {
        static int Max(int[] array)
        {
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int[] GetIn(int number)
        {
            int count = 0;
            for (int i = 1; i < number + 1; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] array = new int[count];
            int index = 0;
            for(int i = 1; i < number + 1; i++)
            {
                if (number % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for (int j = 0; j < strArray.Length; j++)
            //{
            //    int number = Convert.ToInt32(strArray[j]);
            //    intArray[j] = number;
            //}
            //int n = Max(intArray);
            //Console.WriteLine(n);

            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = GetIn(number);
            foreach(int temp in array)
            {
                Console.Write(temp + " ");
            }
        }
    }
}
