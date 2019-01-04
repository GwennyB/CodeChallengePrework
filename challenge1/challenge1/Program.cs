using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = FillArray(5);
            int chosen = PickNum(nums);
            Console.WriteLine($"Score: {CalcScore(chosen, nums)}");
            Console.ReadLine();

        }

        private static int[] FillArray(int arrayLength)
        {
            Console.Clear();
            Console.WriteLine($"Let's fill the array with {arrayLength} integers.");
            int[] numsArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Choose an integer between 1 and 10 (inclusive): ");
                numsArray[i] = Int32.Parse(Console.ReadLine());
            }
            return numsArray;
        }

        private static int PickNum(int[] nums)
        {
            Console.Write($"Now choose a number from the array: [ ");
            foreach(int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("]");
            int numChosen = Int32.Parse(Console.ReadLine());

            return numChosen;
        }

        private static int CalcScore(int chosen, int[] nums)
        {
            int score = 0;
            foreach(int num in nums)
            {
                if (chosen == num)
                    score += num;
            }
            return score;
        }
    }
}
