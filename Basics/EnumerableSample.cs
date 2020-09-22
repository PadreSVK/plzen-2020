using System;
using System.Collections;
using System.Collections.Generic;

namespace Basics
{
    public class EnumerableSample : ISample
    {
        public void Run()
        {
            foreach (var item in new TestEnumerableDuckTyping())
            {
                Console.WriteLine(item);
            }

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
            yield return 1;
            yield return 2;
            yield return 5;
            //yield break;
            yield return 1;
            yield return 8;
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
            private static readonly string[] Names = {"Name1", "Name2", "Name3"};

            //public IEnumerator GetEnumerator()
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
        }

        public class TestEnumerable : IEnumerable
        {
            private static readonly string[] Names = {"Name1", "Name2", "Name3"};

            // IEnumerable Member  
            public IEnumerator GetEnumerator()
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
        }
    }
}