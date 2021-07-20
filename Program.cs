using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                arrayOfInputData[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arrayOfInputData[1]);
            Console.ReadLine();
        }
    }
}
