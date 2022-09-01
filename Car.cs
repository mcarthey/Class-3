using System;

namespace Class_3
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public int Vin { get; private set; }

        // default constructor
        public Car()
        {
            Vin = 23423432;
        }

        public void Start()
        {
            Console.WriteLine($"The {Make} {Model} is started!");
        }

        public void GetVin()
        {
            Console.WriteLine("Enter the VIN");
            var vin = Console.ReadLine();

            //Vin = vin;
        }
    }
}
