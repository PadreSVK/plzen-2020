using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Excercise4
{
    public class Excercise4
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
