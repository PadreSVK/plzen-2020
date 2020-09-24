using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise.Exercise6
{
    public static class Extensions
    {
        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);

                if (predicate(item))
                {
                    yield return item;
                }

            }
        }

        public static void Test()
        {
            IEnumerable<int> enumerable = Enumerable.Range(0, 20);

            var take = enumerable.MyWhere((int i) => i > 5).Take(5);
            var list = take.ToList();
        }

    }
}