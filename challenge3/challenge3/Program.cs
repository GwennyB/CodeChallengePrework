using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                int[] sequence = GetSequence();
                CheckPerfectSequence(sequence);
            }
        }

        private static int[] GetSequence()
        {
            Console.WriteLine("Enter a sequence of numbers (separate with commas): ");
            string sequence = Console.ReadLine();
            string[] splitSequence = sequence.Split(',');
            int[] nums = new int[splitSequence.Length];
            for (int i = 0; i < splitSequence.Length; i++)
            {
                nums[i] = Int32.Parse(splitSequence[i]);
            }
            return nums;
        }

        private static int GetProduct(int[] sequence)
        {
            int sequenceProduct = 1;
            foreach (int num in sequence)
            {
                sequenceProduct *= num;
            }
            return sequenceProduct;
        }

        private static void CheckPerfectSequence(int[] sequence)
        {
            int sequenceSum = sequence.Sum();
            int sequenceProduct = GetProduct(sequence);
            bool negatives = false;
            foreach (int num in sequence)
                if (num < 0)
                    negatives = true;
            if (sequenceSum == sequenceProduct && !negatives)
                Console.WriteLine("This is a perfect sequence.");
            else
                Console.WriteLine("This is not a perfect sequence.");
            Console.ReadLine();
        }
    }
}
