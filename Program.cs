using System;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car yourCar = new Car();

            myCar.Make = "Ford";
            myCar.Model = "Raptor";
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Vin}");
            myCar.Start();

            yourCar.Make = "Jeep";
            yourCar.Model = "Trackhawk";
            Console.WriteLine($"{yourCar.Make} {yourCar.Model} {yourCar.Vin}");
            yourCar.Start();

            // the below is the same conceptually as writing our own Car class
            int myInt1 = 0;
            int myInt2 = 1;

            
            // User will select to read data
            FileAccessor accessor = new FileAccessor();
            accessor.Read();

            // String Interpolation Example
            Console.WriteLine($"{DateTime.Now,40:MMMM dd, yyyy}");
            Console.WriteLine($"{DateTime.Now:yyyy.dd.MM}");
        }

    }
}
