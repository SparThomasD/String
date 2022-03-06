using System;

namespace CIS3025_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Enter a sentence or phrase (no punctuation): ");
            string phrase = System.Console.ReadLine();
            System.Console.WriteLine($"ORIGINAL STRING: \"{phrase}\"");
            System.Console.WriteLine($"LOWERCASE STRING: \"{phrase.ToLower()}\"");
            System.Console.WriteLine($"UPPERCASE STRING: \"{phrase.ToUpper()}\"");
            System.Console.WriteLine($"COMMA-DELIMITED WORDS:\n{phrase.Replace(" ", ",\n")}");
            char[] asChars = phrase.ToLower().Replace(" ", "").ToCharArray();
            System.Array.Reverse(asChars);
            System.Console.WriteLine($"\"{phrase}\" is a palindrome: " + (new string(asChars) == phrase.ToLower().Replace(" ", "")));
            asChars = phrase.ToCharArray();
            System.Array.Sort(asChars);
            System.Console.WriteLine($"SORTED STRING: \"{new string(asChars)}\"");

            System.Console.Write("Enter a character: ");
            char originalChar = System.Console.ReadLine().ToUpper()[0];
            System.Console.Write("Enter an offset (integer in range 0 to 25): ");
            int offset = int.Parse(System.Console.ReadLine());
            char rotatedChar = (char)((originalChar - 'A' + offset) % 26 + 'A');
            System.Console.WriteLine($"{originalChar} rotated by {offset} is {rotatedChar}.");

        }
    }
}