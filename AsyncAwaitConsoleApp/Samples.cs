using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    public class Samples : IExercise
    {
        public async Task RunAsync()
        {
            //todo fire and forget
            Console.ReadKey();
            //await TestAsync();
            //await TestAsync();
            //await TestAsync();

            //try
            //{
            //    Console.WriteLine("try catch begin");
            //      var cancellationTokenSource = new CancellationTokenSource();
            //      //cancellationTokenSource.CancelAfter(500);
            //      //MethodThatCancelAsync(1000);
            //      await LongRunnginTaskAsync(cancellationTokenSource.Token);
            //      //await AsyncAwaitExampleAsync();
            //      Console.WriteLine("try catch end");

            //  }
            //  catch (Exception e)
            //  {
            //      Console.WriteLine(e);
            //      throw;
            //  }

            await AsyncAwaitExampleAsync();
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
            await Task.Delay(2000, cancellationToken);
            throw new Exception("My exception");
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
            for (var i = 0; i < 100; i++)
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

        public static async Task AsyncAwaitExampleAsync()
        {
            var myVariable = 0;

            await DummyMethodAsync();
            Console.WriteLine("Continuation - After First Await");
            myVariable = 1;

            await DummyMethodAsync();
            Console.WriteLine("Continuation - After Second Await");
            myVariable = 2;
        }

        public static async Task DummyMethodAsync()
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
                Console.WriteLine(ex.Message);
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
