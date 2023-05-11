using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMinimumMaksimumSrednoAritmetichno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter count numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
