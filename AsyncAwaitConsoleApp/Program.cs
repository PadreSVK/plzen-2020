using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    internal class Program
    {
        //public static async Task Main(string[] args)
        public static void Main(string[] args)
        {
            Method1Async();
            Method2();
            Console.ReadKey();

            //todo fire and forget
            //Task.Run(() => FireAway());

            //try
            //{
            //    var cancellationTokenSource = new CancellationTokenSource();
            //    cancellationTokenSource.CancelAfter(500);
            //    //MethodThatCancelAsync(1000);
            //    await LongRunnginTaskAsync(cancellationTokenSource.Token);
            //    //await AsyncAwaitExampleAsync();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
        }

        public async Task MethodThatCancelAsync(CancellationTokenSource cancellationTokenSource)
        {
            Console.WriteLine("MethodThatCancelAsync Start");
            await Task.Delay(1000);
            cancellationTokenSource.Cancel();


            Console.WriteLine("MethodThatCancelAsync End");
        }

        public static async Task LongRunnginTaskAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("LongRunnginTaskAsync Start");
            cancellationToken.ThrowIfCancellationRequested();
            await Task.Delay(10000, cancellationToken);
            Console.WriteLine("LongRunnginTaskAsync End");
        }


        public static async Task Method1Async()
        {
            await Task.Run(() =>
            {
                for (var i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (var i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static Task Method3Async()
            //public static async Task Method3Async()
        {
            return Task.CompletedTask;
            //return await Task.CompletedTask;
        }

        public async Task AsyncAwaitExampleAsync()
        {
            var myVariable = 0;

            await DummyMethodAsync();
            Console.WriteLine("Continuation - After First Await");
            myVariable = 1;

            await DummyMethodAsync();
            Console.WriteLine("Continuation - After Second Await");
            myVariable = 2;
        }

        public async Task DummyMethodAsync()
        {
            Console.WriteLine("");
            await Task.CompletedTask;
            //Asynchronous calls here
        }

        public async Task<T> DummyMethodGenericAsync<T>(object arg = null) where T : new()
        {
            Console.WriteLine("");
            return await Task.FromResult(new T());
            //Asynchronous calls here
        }

        public Task<object> ReturnTaskExceptionNotCaughtAsync()
        {
            try
            {
                //Bad idea...
                return DummyMethodGenericAsync<object>();
            }
            catch (Exception ex)
            {
                //The below line will never be reached
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public Task<object> ReturnTaskUsingProblemAsync()
        {
            using (var resource = GetResource())
            {
                //Bad idea...By the time the resource is actually referenced, may have been disposed already
                return DummyMethodGenericAsync<object>(resource);
            }
        }

        public IDisposable GetResource()
        {
            throw new NotImplementedException();
        }
    }
}