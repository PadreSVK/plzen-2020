using System;

namespace Basics
{
    public class Disposable : ISample
    {
        public void Run()
        {
            //var obj = new MyDisposableObject();
            //try
            //{
                
            //    throw new Exception("exception in using");
            //}
            //finally
            //{
            //    obj.Dispose();
            //}




            using (var obj = new MyDisposableObject())
            {
                throw new Exception("exception in using");
                Console.WriteLine("in using block");
            }
            Console.WriteLine("out using block");

        }

        public class MyDisposableObject : IDisposable
        {
            public MyDisposableObject()
            {
                throw new Exception("exception in ctor");
            }
            public void Dispose()
            {
                Console.WriteLine($"{nameof(MyDisposableObject)} object was disposed");
            }
        }
    }
}