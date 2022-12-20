using System;
namespace Testing;

class Tester
{
    // public delegate void LoggingHandler();
    public event EventHandler? TestComplete;

    protected static void SetConsoleColor()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }

    public virtual void PerformTest()
    {
        SetConsoleColor();
        System.Console.WriteLine("Performing BASE Test");
        this.OnTestComplete();
    }

    protected virtual void OnTestComplete()
    {
        // Invoke Subscribers here
        if (TestComplete is not null)
            TestComplete(this, EventArgs.Empty);
    }
}

class BetaTester : Tester
{
    public override void PerformTest()
    {
        SetConsoleColor();
        System.Console.WriteLine("Performing BETA Test");
        base.OnTestComplete();
    }
}