using System;
using System.Collections;
using System.Collections.Generic;
using MyNamespace;

namespace Basics
{
    public class EnumerableSample : ISample
    {
        public void Run()
        {
            var maxCount = 2;
            var count = 0;
            foreach (var i in SimpleEnumerable())
            {
                if (i < 2)
                {
                    count++;
                }

                Console.WriteLine(i);
                if (maxCount == count)
                {
                    break;
                }
            }

            foreach (var item in new TestEnumerableDuckTyping())
            {
                Console.WriteLine(item);
            }

            var testEnumerable = new TestEnumerable();
            var enumerator = testEnumerable.GetEnumerator().MoveNext();

            IEnumerable testEnumerable2 = testEnumerable;
            var enumerator1 = testEnumerable2.GetEnumerator().MoveNext();

            foreach (var item in new TestEnumerable())
            {
                Console.WriteLine(item);
            }

            foreach (var number in GetNumbers(15))
            {
                Console.WriteLine(number);
            }
        }

        public IEnumerable<int> SimpleEnumerable()
        {
            Console.WriteLine("first");
            yield return 1;
            Console.WriteLine("second");
            yield return 2;
            Console.WriteLine("third");
            yield return 5;
            Console.WriteLine("4th");
            //yield break;
            yield return 1;
            Console.WriteLine("5th");
            yield return 8;
            Console.WriteLine("6th");
            yield return 0;
        }

        public IEnumerable<int> GetNumbers(int maxNUmber = 100)
        {
            for (var i = 0; i < maxNUmber; i++)
            {
                Console.WriteLine("start iteration");
                yield return i;
                Console.WriteLine("end iteration");
            }
        }


        public class TestEnumerableDuckTyping
        {
            private static readonly string[] Names = { "Name1", "Name2", "Name3" };

            //public IEnumerator GetEnumerator()
            public IEnumerator<string> GetEnumerator()
            {
                foreach (string o in Names)
                {
                    if (o == null)
                    {
                        break;
                    }

                    yield return o;
                }
            }
        }

        public class TestEnumerable : IEnumerable<string>
        {
            private static readonly string[] Names = { "Name1", "Name2", "Name3" };

            // IEnumerable Member  
            public IEnumerator<string> GetEnumerator()
            {
                foreach (var o in Names)
                {
                    if (o == null)
                    {
                        break;
                    }

                    yield return o;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}