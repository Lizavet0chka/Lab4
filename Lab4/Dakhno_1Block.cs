using System;

namespace Lab4
{
    public partial class Dakhno
    {
        public static void Change(ref int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2==0)
                {
                    count++;
                }
            }
            int[] newArray = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2==0)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            array = newArray;
        }
    }
}