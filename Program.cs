using System;

namespace ArrayFromKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: \t");

            uint elementsCount = 0;

            try
            {
                elementsCount = uint.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели некорректные данные для определения размера массива. Подходят только целые, положительные числа.");
                Environment.Exit(0);
            }
            

            int[] arrayOfInputData;
            arrayOfInputData = new int[elementsCount];

            for (int i = 0; i < arrayOfInputData.Length; i++)
            {
                Console.WriteLine("Введите число, которое будет храниться под индексом " + i);
                try
                {
                    arrayOfInputData[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорректные данные в массив, допустимы  только целые числа.");
                    Environment.Exit(0);
                }
                
            }

            Console.WriteLine("Вывод массива в обратном порядке:");

            for (int i = arrayOfInputData.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayOfInputData[i]);
            }

            Console.ReadLine();
        }
    }
}
