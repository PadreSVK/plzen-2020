using System;
using Basics;
using Basics.Test;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Namespace().Run();
            new Basics.Test.Namespace().Run();
            new CtorFinalizer().Run();
            new Disposable().Run();
            new Exceptions().Run();
            new Attributes().Run();
            new ReflectionSample().Run();
            new EnumerableSample().Run();
            new LambdaSample().Run();
            new ExpressionsSample().Run();
            new EnumerableSample().Run();
            new ReflectionSample().Run();
            new LINQSample().Run();
        }
    }
}