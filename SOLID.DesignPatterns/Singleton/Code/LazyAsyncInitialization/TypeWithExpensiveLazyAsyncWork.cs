namespace SOLID.DesignPatterns.Singleton.Code.NewFolder
{
    public class TypeWithExpensiveLazyAsyncWork
    {
        private readonly Lazy<Task<ExpensivelyCalculatedResults>> dataTaskSource;

        public TypeWithExpensiveLazyAsyncWork()
        {
            dataTaskSource = new(() => ExpensiveWorker.PerformSlowWorkAsync());
        }

        public async ValueTask<string> DoSomethingAsync(string name)
        {
            ExpensivelyCalculatedResults data = await dataTaskSource.Value.ConfigureAwait(false); // ?????
            return data.GetResult(name);
        }
    }
    // https://endjin.com/blog/2023/01/dotnet-csharp-lazy-async-initialization
}
