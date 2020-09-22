using System;

namespace Basics
{
    public class LambdaSample : ISample
    {
        public void Run()
        {
            //Statement lambdas
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");

            //Expression lambdas
            Action line = () => Console.WriteLine("Ahoooj");
            Func<int, int, bool> testForEquality = (x, y) => x == y;
            Func<int, int, int> constant = (_, _) => 42;
        }
    }
}