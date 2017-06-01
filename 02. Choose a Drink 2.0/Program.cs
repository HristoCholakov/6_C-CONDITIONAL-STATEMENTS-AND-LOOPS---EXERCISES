using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalprice = 0;


            if (profesion == "Athlete")
            {
                totalprice = quantity * 0.70; 
            }

            else if (profesion == "Businessman" || profesion == "Businesswoman")
            {
                totalprice = quantity * 1.00;
            }
            else if (profesion == "SoftUni Student")
            {
                totalprice = quantity * 1.70;
            }
            else
            {
                totalprice = quantity * 1.20;
            }

            Console.WriteLine($"The {profesion} has to pay {totalprice:F2}.");


        }
    }
}
