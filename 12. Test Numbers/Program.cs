using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int MaximumSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int totalCombinations = 0;

            for (int i = N; i >=1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    var number = (i * j)*3;
                    sum += number;
                    totalCombinations++;

                    if (sum>=MaximumSum)
                    {
                        Console.WriteLine($"{totalCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {MaximumSum}");

                        return;
                    }
                }
            }
            Console.WriteLine($"{totalCombinations} combinations");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
