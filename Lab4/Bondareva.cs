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
            if(t > array.Length && t<0)
            {
                Console.WriteLine("Помилка, ідекс номер вставки знаходиться за межами масива");
            }
            else
            {
                Array.Resize(ref array, array.Length+elements.Length);
                for (int i = t; i < array.Length - elements.Length; i++)
                {
                    array[i + elements.Length] = array[i];
                }
                for (int i = t; i < array.Length - elements.Length; i++)
                {
                    array[t] = int.Parse(elements[i - t]);
                }
            }
        }
    }
}
