using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    public class Exercise2: IExercise
    {
        public Task RunAsync()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => TestCTSourceAsync(cancellationTokenSource));
            Task.Run(() => TestCTAsync(cancellationTokenSource.Token));
            Console.ReadKey();
            return Task.CompletedTask;
        }

        public static async Task TestCTSourceAsync(CancellationTokenSource cancellationTokenSource)
        {
            Console.WriteLine("TestCTSourceAsync start");
            
            await Task.Delay(3000);
            Console.WriteLine("wait after 3sec");
            await Task.Delay(3000);
            cancellationTokenSource.Cancel();
            Console.WriteLine("TestCTSourceAsync end");

        }
        public static async Task TestCTAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("TestCTAsync start");

            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("TestCTAsync got sleep");
                await Task.Delay(1000);
                //await Task.Delay(1000, cancellationToken);
            }

            Console.WriteLine("TestCTAsync end");
        }
    }
}
