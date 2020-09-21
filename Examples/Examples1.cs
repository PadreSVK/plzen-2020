using System.Collections.Generic;

namespace Examples
{
    public class Examples1
    {
        private static IEnumerable<int> Fibonacci()
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