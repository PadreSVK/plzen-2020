using System.Collections.Generic;
using System.Linq;
using Exercise.Exercise1.Car;
using Exercise.Exercise1.Engine;

namespace Exercise.Exercise3
{
    public static class ExtensionMethods
    {
        public static IEnumerable<ICar<IEngine>> GetAllCarsByEngine<TEngineType>(this IEnumerable<ICar<IEngine>> cars)
            where TEngineType : IEngine
        {
            return cars.Where(c => c.Engine.GetType() == typeof(TEngineType));
        }

        public static IEnumerable<ICar<IEngine>> GetAllCarsWithV8Engine(this IEnumerable<ICar<IEngine>> cars)
        {
            return cars.Where(c => c.Engine.GetType() == typeof(V8Engine));
        }
    }
}