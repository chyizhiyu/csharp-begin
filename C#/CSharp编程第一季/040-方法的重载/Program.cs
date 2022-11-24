using System;

namespace _040_方法的重载
{
    class Program
    {
        static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double MaxValue(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(new int[] { 45, 12, 57, 34, 534, 534, 5323, 324 }));
            Console.WriteLine(MaxValue(new double[] { 45, 12, 57, 34, 534, 534, 5323, 324,23453.3 }));
        }
    }
}
