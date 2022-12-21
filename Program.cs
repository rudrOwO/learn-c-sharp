using Testing;
using Logging;
using learn_dotnet.models;

internal class Program
{
    async public static Task Main()
    {
        var tasks = new List<Task<int>>
        {
            Dummy.TaskAsync(1),
            Dummy.TaskAsync(2),
            Dummy.TaskAsync(3),
            Dummy.TaskAsync(4),
            Dummy.TaskAsync(5),
        };

        var firstTask = await Task.WhenAny(tasks);
        var taskID = await firstTask;
        Console.WriteLine($"First Done : {taskID}");
    }
}
