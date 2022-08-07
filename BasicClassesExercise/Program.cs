using System;
using System.Collections.Generic;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Genesis";
            myCar.Model = "G90";
            myCar.Year = 2018;

            var honda = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2020,
            };

            var infinti = new Car("Infiniti", "QX80", 2014);
            var carList = new List<Car>() { myCar, honda, infinti };
            
            foreach(var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
            
        }
    }
}
