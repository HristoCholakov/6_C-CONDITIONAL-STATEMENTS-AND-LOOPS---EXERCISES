using System;

namespace _06.LetterCombinations
{
    public class LetterCombinations
    {
        public static void Main()
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            
            for (int i = letter1; i <= letter2; i++)
            {
                if (i == letter3) continue;

                for (int m = letter1; m <= letter2; m++)
                {
                    if (m == letter3) continue;

                    for (int q = letter1; q <= letter2; q++)
                    {
                        if (q == letter3) continue;

                        Console.Write($"{(char)i}{(char)m}{(char)q} ");

                    }
                }
            }
            
        }
    }
}