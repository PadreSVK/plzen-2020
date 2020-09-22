using System;
using System.Collections.Generic;
using Exercise.Exercise1.Car;
using Exercise.Exercise1.Engine;
using Exercise.Exercise3;

namespace Exercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICar<IEngine> test = new Mustang();

            var cars = new List<ICar<IEngine>>
            {
                new Mustang(),
                new Mustang(),
                new Mustang(),
                new Mustang(),
                new Mustang(),
            };
            var allCarsWithV8Engine = ExtensionMethods.GetAllCarsWithV8Engine(cars);
            IEnumerable<ICar<IEngine>> allCarsByEngineNonGeneric = cars.GetAllCarsWithV8Engine();

            var allCarsByEngineStaticCalling = ExtensionMethods.GetAllCarsByEngine<V8Engine>(cars);
            IEnumerable<ICar<IEngine>> allCarsByEngine = cars.GetAllCarsByEngine<V8Engine>();
        }
    }
}