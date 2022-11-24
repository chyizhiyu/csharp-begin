using System;

namespace _029_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 30;

            //int age1 = 12;
            //int age2 = 12;
            //int age3 = 12;
            //int age4 = 12;
            //int age5 = 12;
            //int age6 = 12;
            //int age7 = 12;
            //int age8 = 12;
            //int age9 = 12;
            //int age10 = 12;

            //声明int类型的数组
            //int[] ages = { 34, 12, 56, 67, 2, 3, 4, 6, 6, 2 };
            //数组的数据有下标 0  1   2  3    4  5  6  7 8   9（索引） 
            //数组名[索引]
            //Console.WriteLine(ages[7]);
            //
            //double[] temp1;
            //char[] temp2;
            //string[] temp3;

            //赋值方式
            //int[] ages = { 34, 12, 56, 67, 2, 3, 4, 6, 6, 2 };

            //ages[10] = 20;
            //Console.Write(ages[10]);

            //int[] ages;
            //ages = new int[10];//默认值 0
            //Console.Write(ages[4]);
            //ages = new int[] { 12, 1, 1, 2, 4 };

            //ages = new int[4] { 12, 1, 2, 4 };

            //int[] intArray = new int[9];//0
            //char[] charArray = new char[20];
            //float[] floatArray = new float[5];
            //string[] stringArray = new string[8];

            //0-9
            int[] ages = { 34, 12, 56, 67, 2, 3, 4, 6, 6, 2 };

            Console.Write(ages.Length);
            for(int i = 0; i < ages.Length; i++)
            {
                Console.Write(ages[i] + " ");
            }

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write(ages[i]+" ");
            //}

            //for(int i = 9; i >= 0; i--)
            //{
            //    Console.Write(ages[i] + " ");
            //}

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.Write(ages[i] + " ");
            //    i++;
            //}

            //foreach
            //foreach(int temp in ages){
            //    Console.Write(temp + " ");
            //}

        }
    }
}
