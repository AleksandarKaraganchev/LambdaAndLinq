using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("Enter sentence: ");
        string sentence = Console.ReadLine().ToLower();
        char[] charseparator = new char[] { ',', '.', ':', ';', ')', '(', ']', '[', '\\', '\"', '\'', '/', '!', ' ', '?' };
        string[] words = sentence.Split(charseparator);
        var result = words.
            Where(x => x.Length < 5)
            .OrderBy(w => w)
            .Distinct();
        Console.WriteLine(string.Join("  ", result));
    }
}

