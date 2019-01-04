using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a year: ");
                int year = Int32.Parse(Console.ReadLine());
                CheckLeap(year);
            }
        }

        private static void CheckLeap(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is not a leap year.");
            Console.ReadLine();
        }

    }
}
