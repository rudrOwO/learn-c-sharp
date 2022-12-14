using System;
namespace Testing;

class Tester
{
    // public delegate void LoggingHandler();
    public event EventHandler? TestComplete;

    protected void SetConsoleColor()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }

    public virtual void PerformTest()
    {
        this.SetConsoleColor();
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
        base.SetConsoleColor();
        System.Console.WriteLine("Performing BETA Test");
        base.OnTestComplete();
    }
}