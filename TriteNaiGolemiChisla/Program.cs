using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //method 1 - longer
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //Console.Write("Enter a list of real numbers (separated by spaces): ");
        //string input = Console.ReadLine();
        //string[] nums = input.Split(' ');
        //List<double> realNums = new List<double>();
        //foreach (string number in nums)
        //{
        //    if (double.TryParse(number, out double parsedNumber))
        //    {
        //        realNums.Add(parsedNumber);
        //    }
        //}
        //List<double> largestNumbers = realNums.OrderByDescending(x => x)
        //    .Take(3)
        //    .ToList();
        //Console.WriteLine("The 3 largest numbers are:");
        //Console.WriteLine("-------------------------------------------");
        //foreach (var item in largestNumbers)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("-------------------------------------------");

        //method 2 -shorter and also better
        Console.Write("Enter a list of real numbers (separated by spaces): ");
        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(string.Join(" ", n.OrderByDescending(x => x).Take(3)));
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();
    }
}

