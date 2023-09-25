namespace SOLID.DesignPatterns.Singleton.Code.NewFolder
{
    internal class ExpensivelyCalculatedResults
    {
        public TimeOnly StartedAtTime { get; internal set; }
        public TimeOnly FinishedAtTime { get; internal set; }

        internal string GetResult(string name)
        {
            return "Hi " + name + " Started at: " + StartedAtTime.ToLongTimeString() 
                + " Finished at: " + FinishedAtTime.ToLongTimeString();
        }
    }
}