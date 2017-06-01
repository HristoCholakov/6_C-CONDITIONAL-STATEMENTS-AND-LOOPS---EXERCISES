using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var caloriesCounter = 0;
            string ingredient = "";

            for (int i = 1; i <= n; i++)
            {
                ingredient = Console.ReadLine().ToLower();


                if (ingredient == "cheese")
                {
                    caloriesCounter += 500;
                }
                if (ingredient == "tomato sauce")
                {
                    caloriesCounter += 150;
                }
                if (ingredient == "salami")
                {
                    caloriesCounter += 600;
                }
                if (ingredient == "pepper")
                {
                    caloriesCounter += 50;
                }


            }
            Console.WriteLine($"Total calories: {caloriesCounter}");
        }
    }
}
