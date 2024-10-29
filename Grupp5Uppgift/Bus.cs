using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grupp5Uppgift
{
    public class Bus
        {
            public string Color { get; set; }
            public int Year { get; set; }

            public Bus(string color, int year)
            {
                Color = color;
                Year = year;
            }

            public void DisplayCarInfo()
            {
                Console.WriteLine($"Color: {Color}, Year: {Year}");
            }
        }
}