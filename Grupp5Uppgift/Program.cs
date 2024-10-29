namespace Grupp5Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Car
        {
            public string Color { get; set; }
            public int Year { get; set; }

            public Car(string color, int year)
            {
                Color = color;
                Year = year;
            }

            // Method
            public void DisplayCarInfo()
            {
                Console.WriteLine($"Color: {Color}, Year: {Year}");
            }
        }

    }
}
