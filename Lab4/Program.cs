﻿using System;

namespace Lab4
{
    internal class Program
    {
        public static int[] CreateArray_1(int countOfElements, ref int[] array)
        {   
            //Console.Write("Введіть к-сть елементів: ");
            //int countOfElements = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[countOfElements];
            Console.WriteLine("Введіть 1, щоб заповнити масив рандомно, або 2, щоб заповнити його самостійно: ");
            int choiceOfInput = Convert.ToInt32(Console.ReadLine());
            switch (choiceOfInput)
            {
                case 1:
                    InputRandom_1(countOfElements, ref array);
                    Console.Write("Початковий масив: ");
                    for (int i = 0; i < countOfElements; i++)
                    {
                            Console.Write(array[i]+ " ");
                    }
                    break;
                case 2:
                    Console.Write("Введіть масив:");
                    Input_1(countOfElements, ref array);
                    break;
            }
            return array;
        }
        static int[] InputRandom_1(int countOfElements, ref int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < countOfElements; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }
        static int[] Input_1(int countOfElements, ref int[] array)
        {
            string[] rowOfArray = Console.ReadLine().Trim().Split();
            for (int i = 0; i < countOfElements; i++)
            {
                array[i] = Convert.ToInt32(rowOfArray[i]);
            }

            return array;
        }
        static int[] Change(ref int[] array)
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
            return array;
        }
        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
        public static void Block_1()
        {
            Console.Write("Введіть к-сть елементів: ");
            int countOfElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[countOfElements];
            CreateArray_1(countOfElements, ref  array);
            Console.Write("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            do
            {
                switch (choiceOfStudent)
                {
                    case "дахно":
                        Change(ref array);
                        break;
                    case "бондарева":
                        break;
                    case "глущенко":
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                Output(array);
                Console.WriteLine();
                Console.Write("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                Console.WriteLine("Бажаєте створити новий масив?(Так/Ні)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "так")
                {
                    Console.Write("Введіть к-сть елементів: ");
                    countOfElements = Convert.ToInt32(Console.ReadLine());
                    array = new int[countOfElements];
                    CreateArray_1(countOfElements, ref  array);
                }
            } while (choiceOfStudent!="0");
        }
        
        public static void Block_2()
        {
            Console.Write("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            do
            {
                switch (choiceOfStudent)
                {
                    case "дахно":
                        break;
                    case "бондарева":
                        break;
                    case "глущенко":
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                
                Console.Write("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                Console.WriteLine("Бажаєте створити новий масив?(Так/Ні)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "так")
                {
                    
                }
            } while (choiceOfStudent!="0");
        }
        public static void Main(string[] args)
        {
            Console.Write("Введіть номер задачі, яку хочете виконати. Якщо бажаєте завершити виконання програми введіть 0. ");
            int choiceOfTask = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choiceOfTask)
                {
                    case 1:
                        Block_1();
                        break;
                    case 2:
                        Block_2();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.Write("Введіть номер задачі, яку хочете виконати. Якщо бажаєте завершити виконання програми введіть 0. ");
                choiceOfTask = Convert.ToInt32(Console.ReadLine());
            } while (choiceOfTask!=0);
            
        }
    }
}