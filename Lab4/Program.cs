using System;
using System.Runtime.InteropServices;

namespace Lab4
{
    internal class Program
    {
        public static void CreateArray_1(int countOfElements, ref int[] array)
        {
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
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Введіть масив:");
                    Input_1(countOfElements, ref array);
                    break;
            }
        }
        static void InputRandom_1(int countOfElements, ref int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < countOfElements; i++)
            {
                array[i] = random.Next(-100, 100);
            }
        }
        static void Input_1(int countOfElements, ref int[] array)
        {
            string[] rowOfArray = Console.ReadLine().Trim().Split();
            for (int i = 0; i < countOfElements; i++)
            {
                array[i] = Convert.ToInt32(rowOfArray[i]);
            }
        }
        
        static void Output_1(int[] array)
        {
            if (array.Length==0)
            {
                Console.WriteLine("Знищено всі елементи масиву");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Block_1()
        {
            Console.WriteLine("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            Console.Write("Введіть к-сть елементів: ");
            int countOfElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[countOfElements];
            CreateArray_1(countOfElements, ref  array);
            do
            {
                switch (choiceOfStudent)
                {
                    case "дахно":
                        Dakhno_1.Change(ref array);
                        Console.WriteLine("Результат:");
                        Output_1(array);
                        break;
                    case "бондарева":
                        Console.WriteLine("Результат:");
                        Output_1(array);
                        break;
                    case "глущенко":
                        Hlushchenko_1.Change(ref array);
                        Console.WriteLine("Результат:");
                        Output_1(array);
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                Console.WriteLine("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                if (choiceOfStudent == "дахно" || choiceOfStudent == "бондарева" || choiceOfStudent == "глущенко")
                {
                    Console.WriteLine("Бажаєте створити новий масив?(Так/Ні)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.Write("Введіть к-сть елементів: ");
                        countOfElements = Convert.ToInt32(Console.ReadLine());
                        array = new int[countOfElements];
                        CreateArray_1(countOfElements, ref  array);
                    }
                }
            } while (choiceOfStudent!="0");
        }
        public static void CreateArray_2(int rows, int col, ref int[][] array)
        {
            Console.Write("Введіть 1, щоб заповнити масив рандомно, або 2, щоб заповнити його самостійно: ");
            int choiceOfInput = Convert.ToInt32(Console.ReadLine());
            switch (choiceOfInput)
            {
                case 1:
                    InputRandom_2(rows, col, ref array);
                    Console.WriteLine("Початковий масив: ");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(array[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Введіть масив:");
                    Input_2(rows, col, ref array);
                    break;
            }
        }
        static void InputRandom_2(int rows, int col, ref int[][] array)
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    array[i][j] = random.Next(-100, 100);
                }
            }
        }
        static void Input_2(int rows, int col, ref int[][] array)
        {
            for (int i = 0; i < rows; i++)
            {
                string[] rowOfArray = Console.ReadLine().Trim().Split();
                array[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    array[i][j] = Convert.ToInt32(rowOfArray[j]);
                }
            }
        }
        static void Output_2(int rows, int col, int[][] array)
        {
            if (rows==0)
            {
                Console.WriteLine("Знищено всі елементи масиву");
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(array[i][j]+" ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Block_2()
        {
            Console.WriteLine("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
            string choiceOfStudent = Console.ReadLine().ToLower();
            Console.Write("Введіть к-сть рядків та стовпчиків в масиві: ");
            string[] size = Console.ReadLine().Trim().Split();
            int rows = Convert.ToInt32(size[0]);
            int col = Convert.ToInt32(size[1]);
            int[][] array = new int[rows][];
            CreateArray_2(rows, col, ref array);
            do
            {
                switch (choiceOfStudent)
                {
                    case "дахно":
                        Dakhno_2.Change(ref rows, col, ref array);
                        Console.WriteLine("Результат:");
                        Output_2(rows, col, array);
                        break;
                    case "бондарева":
                        Console.WriteLine("Результат:");
                        Output_2(rows, col, array);
                        break;
                    case "глущенко":
                        Hlushchenko_2.Change(ref rows, col, ref array);
                        Console.WriteLine("Результат:");
                        Output_2(rows, col, array);
                        break;
                    default:
                        Console.WriteLine("Спробуйте ще раз");
                        break;
                }
                Console.WriteLine("Введіть прізвище студента, варіант якого хочете виконати. Для завершення виконання варіанту програми введіть 0. ");
                choiceOfStudent = Console.ReadLine().ToLower();
                if (choiceOfStudent == "дахно" || choiceOfStudent == "бондарева" || choiceOfStudent == "глущенко")
                {
                    Console.WriteLine("Бажаєте створити новий масив?(Так/Ні)");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.Write("Введіть к-сть рядків та стовпчиків в масиві: ");
                        size = Console.ReadLine().Trim().Split();
                        rows = Convert.ToInt32(size[0]);
                        col = Convert.ToInt32(size[1]);
                        array = new int[rows][];
                        CreateArray_2(rows, col, ref  array);
                    }
                }
            } while (choiceOfStudent!="0");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер задачі, яку хочете виконати. Якщо бажаєте завершити виконання програми введіть 0.");
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
                Console.WriteLine("Введіть номер задачі, яку хочете виконати. Якщо бажаєте завершити виконання програми введіть 0. ");
                choiceOfTask = Convert.ToInt32(Console.ReadLine());
            } while (choiceOfTask!=0);
            
        }
    }
}