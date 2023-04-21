using System;

namespace Lab4
{
    public partial class Dakhno_1
    {
        public static void Change(ref int[] array)
        {
            int count = 0;
            int temp = 0;
            for (int i = 0; i+temp < array.Length; i++)
            {
                array[i] = array[i + temp];
                temp++;
                count++;
            }
            Array.Resize(ref array, count);
        }
    }
    public partial class Dakhno_2
    {
        public static void Change(ref int rows, int col, ref int[][] array)
        {
            Console.WriteLine("Введіть діапазон який потрібно видалити:");
            string[] range = Console.ReadLine().Trim().Split();
            int K1 = Convert.ToInt32(range[0]);
            int K2 = Convert.ToInt32(range[1]);
            bool flag;
            if (K1>K2 || K1+K2 <= K1)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            while (!flag)
            {
                flag = true;
                Console.WriteLine("Такий діапазон неможливий. Спробуйте ще раз.");
                range = Console.ReadLine().Trim().Split();
                K1 = Convert.ToInt32(range[0]);
                K2 = Convert.ToInt32(range[1]);
                if (K1>K2 || K1+K2 <= K1)
                {
                    flag = false;
                }
            }
            if (K1<1)
            {
                K1 = 1;
            }
            if (K2>rows)
            {
                K2 = rows;
            }
            int[][] newArray = new int[rows-Math.Abs(K1-K2)+1][];
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i<K1-1 || i>K2-1)
                {
                    newArray[count] = new int[col];
                    for (int k = 0; k < col; k++)
                    {
                        newArray[count][k] = array[i][k];
                    }
                    count++;
                }
            }
            rows -= Math.Abs(K1 - K2)+1;
            array = newArray;
        }
    }
}