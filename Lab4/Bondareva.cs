using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class Bondareva1
    {
        public static void Task1_10(ref int[] array)
        {
            Console.WriteLine("Введіть елементи, які хочете вставити в масив, через пробіл:");
            string[] elements = Console.ReadLine().Trim().Split();
            Console.WriteLine("Введіть номер починаючи з якого ви хочете вставити елементи в масив:");
            int t = int.Parse(Console.ReadLine());
            if(t > array.Length || t<0)
            {
                Console.WriteLine("Помилка, ідекс номер вставки знаходиться за межами масива");
            }
            else
            {
                Array.Resize(ref array, array.Length+elements.Length);
                for (int i = array.Length - elements.Length-1; i > t-1; i--)
                {
                    array[i+elements.Length] = array[i];
                }
                for (int i = t; i < t+ elements.Length; i++)
                {
                    array[i] = int.Parse(elements[i - t]);
                }
            }
        }

    }
    public partial class Bondareva2
    {
        public static void Task2_10(ref int[][] array, int cols,ref int rows)
        {
            int[][] newArray = new int[array.GetLength(0)+ (int)(array.GetLength(0)/2)][];
            int k = 0;
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                if((i+1)%3==0)
                {
                    Console.WriteLine($"Введіть рядок, який буде додано після парного рядка матриці ({(i+1)/3 *2}):");
                    string[] line = Console.ReadLine().Trim().Split();
                    newArray[i] = new int[line.Length];
                    for (int j = 0; j < line.Length; j++)
                    {
                        newArray[i][j]= Convert.ToInt32(line[j]);
                    }
                }
                else
                {
                    newArray[i]= array[k];
                    k++;
                }
            }
            rows = newArray.GetLength(0);   
            array = newArray;
        }
    }
}
