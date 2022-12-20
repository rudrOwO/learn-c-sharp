using Testing;
using Logging;
using learn_dotnet.models;

internal class Program
{
    private static void Main()
    {
        "Hola Amigos Buenos Dias".Dump();
        "Say My Name".Dump("--> Heisenberg");
    }

    public static void NewHandler(object? source, EventArgs eventArgs)
    {
        System.Console.WriteLine("NEW Handler invoked");
    }
}