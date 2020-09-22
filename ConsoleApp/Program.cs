using System;
using Basics;
using Basics.OtherTest;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
