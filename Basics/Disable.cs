using System;

namespace Basics
{
    public class Disable : ISample
    {
        public void Run()
        {
            using (var obj = new MyDisposableObject())
            {
                Console.WriteLine("in using block");
            }
            Console.WriteLine("out using block");

        }

        public class MyDisposableObject : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine($"{nameof(MyDisposableObject)} object was disposed");
            }
        }
    }
}