using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var mounth = Console.ReadLine();
            double nightsCount = double.Parse(Console.ReadLine());
            double StudioPrice = 0;
            double DoublePrice = 0;
            double SuitePrice = 0;
            double StudioTotal = 0;
            double DoubleTotal = 0;
            double SuiteTotal = 0;


            if (mounth == "May" || mounth == "October")
            {
                StudioPrice = 50;
                DoublePrice = 65;
                SuitePrice = 75;
                if (nightsCount >= 7)
                {
                    StudioPrice *= 0.95;
                    
                }
                

            }
            else if (mounth == "June" || mounth == "September")
            {
                StudioPrice = 60;
                DoublePrice = 72;
                SuitePrice = 82;
                if (nightsCount >= 14)
                {
                    DoublePrice *= 0.90;
                }
                
            }
            else if (mounth == "July" || mounth == "August" || mounth == "December")
            {
                StudioPrice = 68;
                DoublePrice = 77;
                SuitePrice = 89;
                if (nightsCount >= 14)
                {
                    SuitePrice *= 0.85;
                }
            }

            StudioTotal = StudioPrice * nightsCount;
            DoubleTotal = DoublePrice * nightsCount;
            SuiteTotal = SuitePrice * nightsCount;
            if (mounth == "September" || mounth == "October" && nightsCount >=7 )
            {
                StudioTotal = StudioTotal - StudioPrice;
            }

            Console.WriteLine($"Studio: {StudioTotal:F2} lv.");
            Console.WriteLine($"Double: {DoubleTotal:F2} lv.");
            Console.WriteLine($"Suite: {SuiteTotal:F2} lv.");
        }
    }
}
