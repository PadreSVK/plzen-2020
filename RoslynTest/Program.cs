using System;
using System.Threading.Tasks;

namespace RoslynTest
{
    internal class Program
    {
#pragma warning disable VSTHRD200
        private static async Task Main(string[] args)
#pragma warning restore VSTHRD200
        {
            await TestAsync();
            Console.WriteLine("Hello World!");
        }

        private static async Task TestAsync()
        {
            var fromResult = await Task.FromResult(1);
        }
    }
}