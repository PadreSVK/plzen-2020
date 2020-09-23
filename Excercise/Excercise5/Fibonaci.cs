using System.Collections.Generic;

namespace Exercise
{
    public class Fibonaci
    {
        private static IEnumerable<int> GetFibonacci()
        {
            var first = 0;
            var second = 1;

            yield return first;
            yield return second;

            while (true)
            {
                (first, second) = (second, second + first);
                yield return second;
            }
        }
    }
}