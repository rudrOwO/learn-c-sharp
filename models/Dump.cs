namespace learn_dotnet.models;

public static class Dummy
{
    public static void Dump(this string s)
    {
        Console.WriteLine(s);
    }

    async public static Task TaskAsync(int id)
    {
        var client = new HttpClient();
        await client.GetStringAsync("https://example.com");
        Console.WriteLine($"Executing {id}th Task");
    }

    public static void Dump(this string s, string id)
    {
        Console.WriteLine(s);
        Console.WriteLine(id);
    }
}