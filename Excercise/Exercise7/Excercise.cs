using System.Collections.Generic;
using System.Linq;
using Exercise.Exercise1.Car;
using Exercise.Exercise1.Engine;

namespace Exercise.Exercise7
{
    public class Excercise
    {
        public static void Run()
        {
            IEnumerable<ICar<IEngine>> cars = new List<ICar<IEngine>>
            {
                new Mustang(new V8Engine("a54824fa-3190-412d-846c-ec406cd3cd1d")),
                new Mustang(new V8Engine("a54824fa-3190-3190-846c-ec406cd3cd1d")),
                new Mustang(new V8Engine("a54824fa-846c-412d-846c-ec406cd3cd1d")),
                new Mustang(new V8Engine("a54824fa-846c-3190-846c-ec406cd3cd1d")),
                new Trabant(new ClassicEngine("a54824fa-846c-412d-412d-ec406cd3cd1d")),
                new Trabant(new ClassicEngine("a54824fa-846c-412d-412d-ec406cd3cd1d")),
                new Trabant(new ClassicEngine("a54824fa-846c-412d-412d-ec406cd3cd1d"))
            };

            IEnumerable<IEngine> engines = cars.Select(i => i.Engine);

            IEnumerable<V8Engine> v8Engines = engines.OfType<V8Engine>();

            //(cars as List<ICar<IEngine>>).Clear();
            IEnumerable<ClassicEngine> classicEngines = engines.OfType<ClassicEngine>();


            var v8Engines2 = cars.Select(i => i.Engine).OfType<V8Engine>().ToList();
            var enginesOfType = cars.EnginesOfType<V8Engine>().ToDictionary(i => i.VIN);
        }
    }

    public static class Extensions
    {
        public static IEnumerable<T> EnginesOfType<T>(this IEnumerable<ICar<IEngine>> cars)
            where T : class, IEngine
        {
            return cars.Select(i => i.Engine).OfType<T>();
        }
    }
}