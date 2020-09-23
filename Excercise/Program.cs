using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Exercise1.Car;
using Exercise.Exercise1.Engine;
using Exercise.Exercise3;
using Exercise.Exercise5;
using Exercise.Exercise6;

namespace Exercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICar<IEngine> test = new Mustang(new V8Engine("ca412e5e-a731-4b9c-8176-1341035db2fa"));

            var cars = new List<ICar<IEngine>>
            {
               new Mustang(new V8Engine( "a54824fa-3190-412d-846c-ec406cd3cd1d")),
               new Mustang(new V8Engine( "a54824fa-3190-3190-846c-ec406cd3cd1d")),
               new Mustang(new V8Engine( "a54824fa-846c-412d-846c-ec406cd3cd1d")),
               new Mustang(new V8Engine( "a54824fa-846c-3190-846c-ec406cd3cd1d")),
               new Trabant(new ClassicEngine( "a54824fa-846c-412d-412d-ec406cd3cd1d")),
               new Trabant(new ClassicEngine( "a54824fa-846c-412d-412d-ec406cd3cd1d")),
               new Trabant(new ClassicEngine( "a54824fa-846c-412d-412d-ec406cd3cd1d")),
            };

            var allCarsWithV8Engine = ExtensionMethods.GetAllCarsWithV8Engine(cars);
            IEnumerable<ICar<IEngine>> allCarsByEngineNonGeneric = cars.GetAllCarsWithV8Engine();

            var allCarsByEngineStaticCalling = ExtensionMethods.GetAllCarsByEngine<V8Engine>(cars);
            IEnumerable<ICar<IEngine>> allCarsByEngine = cars.GetAllCarsByEngine<V8Engine>();

            foreach (var i in Fibonaci.GetFibonacci().Skip(6).Take(15))
            {
                Console.WriteLine(i);
            }

            Extensions.Test();
        }
    }
}