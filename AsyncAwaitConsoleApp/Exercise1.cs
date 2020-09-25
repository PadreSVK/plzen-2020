using System.Threading.Tasks;

namespace AsyncAwaitConsoleApp
{
    public class Exercise1 : IExercise
    {
        //inheritance Task<string> : Task
        public async Task RunAsync()
        {
            string result = await GetStringAsync();
        }

        public async Task<string> GetStringAsync()
        {
            return "asdasdas";
            //return await Task.FromResult("hi from task");
        }
    }
}