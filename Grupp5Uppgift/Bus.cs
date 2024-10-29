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
             public string Model { get; set; }

        public Bus(string color, int year, string model)
            {,
                Color = color;
                Year = year;
            Model = model;
            }

            public void DisplayCarInfo()
            {
                Console.WriteLine($"Color: {Color}, Year: {Year}");
            }
        }
}