using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] theMatrix = SizeMatrix();
            int[] sumsArray = BuildMatrix(theMatrix);

            Console.ReadLine();
        }

        private static int[,] SizeMatrix()
        {
            Console.WriteLine("How many rows in your matrix?");
            int rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many columns in your matrix?");
            int cols = Int32.Parse(Console.ReadLine());
            int[,] theMatrix = new int[rows, cols];
            return theMatrix;
        }

        private static int[] BuildMatrix(int[,] theMatrix)
        {
            int[] sumsArray = new int[theMatrix.GetLength(0)];
            Console.WriteLine("Random Matrix: ");
            Console.WriteLine("[ ");
            Random random = new Random();
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                Console.Write("  [ ");
                sumsArray[i] = 0;
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    theMatrix[i, j] = random.Next(-100, 100);
                    sumsArray[i] += theMatrix[i, j];
                    Console.Write(theMatrix[i, j] + " "); // write elements in the row
                }
                Console.Write(" ] ");
                Console.WriteLine(); // new line for next row
            }
            Console.WriteLine("]");
            Console.WriteLine("Row sums: [{0}]", string.Join(", ", sumsArray));
            return sumsArray;
        }

    }
}
