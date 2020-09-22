using System.Collections.Generic;
using System.Linq;
using Exercise.Car;
using Exercise.Engine;

namespace Exercise
{
    public static class ExtensionMethods
    {
        public static IEnumerable<ICar<IEngine>> GetAllCarsByEngine<TEngineType>(IEnumerable<ICar<IEngine>> cars)
            where TEngineType : IEngine
        {
            return cars.Where(c => c.Engine.GetType() == typeof(TEngineType));
        }
    }
}