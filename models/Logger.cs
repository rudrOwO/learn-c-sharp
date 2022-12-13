using System;
namespace Logging;

class Logger
{
    public void Log(object? source, EventArgs eventArgs)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Test Complete");
    }
}