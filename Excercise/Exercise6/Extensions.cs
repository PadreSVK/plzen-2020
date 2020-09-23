using System;
using System.Collections.Generic;

namespace Exercise.Exercise6
{
    public static class Extensions
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source,
            Func<TSource, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
        
    }
}