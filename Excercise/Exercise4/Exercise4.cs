using System.Collections.Generic;

namespace Exercise.Exercise4
{
    public class Exercise4
    {
        public static IEnumerable<string> GetStrings(int maxNumberOfItems)
        {
            for (var i = 0; i < maxNumberOfItems; i++)
            {
                yield return $"original string {i}";
            }
        }
    }
}
