using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    public class Exercise3 : IExercise
    {
        public Task RunAsync()
        {
            var boolValue = Exercise3MethodAsync<MySimpleType>(item => item.Age, CancellationToken.None);
            return boolValue;
        }

        // see default for CancellationToken https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken.none?view=netstandard-2.0#remarks
        public async Task<bool> Exercise3MethodAsync<T>(Func<T, int> getNumberFunc,
            CancellationToken cancellationToken = default(CancellationToken))
            where T : new()
        {
            await Task.Delay(1000, cancellationToken);
            var item = new T();
            int result = getNumberFunc(item);
            return result > 5;
        }

        //public Task<bool> Exercise3MethodAsync<T>(Func<T, int> getNumberFunc)
        //    where T : new()
        //{
        //    return Exercise3MethodAsync<T>(getNumberFunc, CancellationToken.None);
        //}

        public class MySimpleType
        {
            public int Age { get; set; } = 1500;
        }
    }
}