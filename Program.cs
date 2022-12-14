using Testing;
using Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        var tester = new Tester();
        var logger = new Logger();

        // Emulating subscription
        tester.TestComplete += logger.Log;
        tester.TestComplete += NewHandler;

        // Event Trigger
        tester.PerformTest();
    }

    public static void NewHandler(object? source, EventArgs eventArgs)
    {
        System.Console.WriteLine("NEW Handler invoked");
    }
}