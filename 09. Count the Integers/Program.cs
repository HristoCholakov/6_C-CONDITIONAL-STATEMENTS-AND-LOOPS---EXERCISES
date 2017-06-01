using System;
 

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    return;
                }

            }

        }
    }
}