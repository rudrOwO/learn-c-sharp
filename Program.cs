using Testing;
using Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        "Hola Amigos Buenos Dias".Dump();
    }

    public static void NewHandler(object? source, EventArgs eventArgs)
    {
        System.Console.WriteLine("NEW Handler invoked");
    }
}