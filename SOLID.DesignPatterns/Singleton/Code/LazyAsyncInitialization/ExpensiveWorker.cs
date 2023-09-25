namespace SOLID.DesignPatterns.Singleton.Code.NewFolder
{
    internal class ExpensiveWorker
    {
        internal static async Task<ExpensivelyCalculatedResults> PerformSlowWorkAsync()
        {
            TimeOnly startedAt = TimeOnly.FromDateTime(DateTime.Now);

            await Task.Delay(2000);

            return new ExpensivelyCalculatedResults()
            {
                StartedAtTime = startedAt,
                FinishedAtTime = TimeOnly.FromDateTime(DateTime.Now)
            };
        }
    }
}