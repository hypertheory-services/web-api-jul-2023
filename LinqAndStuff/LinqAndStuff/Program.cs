

using System.Diagnostics;

//var worker = new DoSomeWork();
//Console.WriteLine("Hit Enter to Do The Work");
//Console.ReadLine();

//var sw = new Stopwatch();
//sw.Start();
//foreach(var number in  worker.GetNumbersEnumerable())
//{

//    Console.WriteLine(number);
//    if (number == 10) break;
//}
//sw.Stop();

//Console.WriteLine($"That took about {sw.ElapsedMilliseconds} Milliseconds");


var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var aWayToGetTheEvenNumbersOutOfThatListOfNumbersWhenYouNeedIt = numbers.Where(NumberStuff.IsEven);

numbers[0] = 8;

var actualEvens = aWayToGetTheEvenNumbersOutOfThatListOfNumbersWhenYouNeedIt.Sum();
Console.WriteLine("There are this many even numbers", actualEvens);

public class DoSomeWork
{

    public List<int> GetNumbers()
    {
        var response = new List<int>();
        for (var t = 0; t < 100; t++)
        {
            Thread.Sleep(10);
            response.Add(t);
        }
        return response;
    }

    public IEnumerable<int> GetNumbersEnumerable()
    {
        for (var t = 0; t < 100; t++)
        {
            Thread.Sleep(10);
            yield return t;
        }
    }
}

public static class NumberStuff
{
    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }
}