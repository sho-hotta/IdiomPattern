// See https://aka.ms/new-console-template for more information

var str = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

var strArray = str.Split(';');
foreach (var s in strArray)
{
    int index = s.IndexOf("=");
    Console.WriteLine($"{s.Substring(0, index)}: {s.Substring(index + 1)}");
}
