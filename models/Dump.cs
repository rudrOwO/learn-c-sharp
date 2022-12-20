namespace learn_dotnet.models;

public static class DumpString
{
    public static void Dump(this string s)
    {
        Console.WriteLine(s);
    }
    public static void Dump(this string s, string id)
    {
        Console.WriteLine(s);
        Console.WriteLine(id);
    }
}