using System;
using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await new Exercise1().RunAsync();
            await new Exercise2().RunAsync();
            await new Exercise3().RunAsync();
            //await new Samples().RunAsync();
            Console.ReadKey();
        }
    }
}