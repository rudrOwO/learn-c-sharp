namespace learn_dotnet.models;

public static class Dummy
{
    public static void Dump(this string s)
    {
        Console.WriteLine(s);
    }

    async public static Task TaskAsync()
    {
        var threadID = Environment.CurrentManagedThreadId;
        var client = new HttpClient();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Executing on Thread {threadID}");
        Console.ForegroundColor = ConsoleColor.Gray;

        await client.GetStringAsync("https://www.google.com");
    }

    public static void Dump(this string s, string id)
    {
        Console.WriteLine(s);
        Console.WriteLine(id);
    }
}