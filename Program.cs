using Testing;
using Logging;
using learn_dotnet.models;

var tasks = new List<Task>
{
    Dummy.TaskAsync(),
    Dummy.TaskAsync(),
    Dummy.TaskAsync(),
    Dummy.TaskAsync(),
    Dummy.TaskAsync(),
};

await Task.WhenAll(tasks);
Console.WriteLine("All Done");
