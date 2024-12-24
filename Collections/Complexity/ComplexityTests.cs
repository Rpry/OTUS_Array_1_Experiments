using System.Diagnostics;
using AutoFixture;

namespace Collections.Complexity;

public class ComplexityTests
{
    protected IEnumerable<string> shortArray;
    protected IEnumerable<string> middleArray;
    protected IEnumerable<string> longArray;
    protected string newItem = "newItem";

    public ComplexityTests()
    {
        Fixture autoFixture = new Fixture();

        autoFixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
            .ForEach(b => autoFixture.Behaviors.Remove(b));
        autoFixture.Behaviors.Add(new OmitOnRecursionBehavior());

        shortArray = autoFixture.CreateMany<string>(1);
        middleArray = autoFixture.CreateMany<string>(500000);
        longArray = autoFixture.CreateMany<string>(1000000);
    }
    
    protected void RunWithStopwatch(Action action, bool loggingEnabled)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        action();
        stopwatch.Stop();
        if (loggingEnabled)
        {
            Console.WriteLine(stopwatch.Elapsed);    
        }
    }
}