using System;

namespace ArrayFromKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInputData;
            arrayOfInputData = new int[3];

            for (int i = 0; i < arrayOfInputData.Length; i++)
            {
                Console.WriteLine("Введите число, которое будет храниться под индексом " + i);
                arrayOfInputData[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введённые вами числа: " + arrayOfInputData[0] + " " + arrayOfInputData[1] + " " + arrayOfInputData[2]);
            Console.ReadLine();
        }
    }
}
