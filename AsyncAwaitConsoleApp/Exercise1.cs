using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    public class Exercise1 : IExercise
    {
        //inheritance Task<string> : Task
        public Task RunAsync() => GetStringAsync();

        public Task<string> GetStringAsync() => Task.FromResult("hi from task");
    }
}