using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowInput = Console.ReadLine().Split();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            int[] items = new int[rowInput.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = int.Parse(rowInput[i]);
            }
            foreach (var item in items)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }
            result = evenSum - oddSum;
            Console.WriteLine(result);


        }
    }
}
        
