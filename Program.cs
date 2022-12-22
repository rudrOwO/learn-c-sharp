using Logging;
using learn_dotnet.models;
using System.Linq;

var numbers = new int[] {5, 4, 1, 2, 3, 4, 5, 8, 9};

int i = 0;
//var q = from n in numbers 
//        select n * n;

var q = numbers.Select(n => i++);

Console.WriteLine(q.GetType());

var parity = 0;
foreach (var v in q)
{
    //if (parity % 2 == 0)
    //{
    //    Console.WriteLine($"v = {v}, i = {i}");
    //}
    //
    //parity++;
}

Console.WriteLine(i);