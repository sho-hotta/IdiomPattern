// See https://aka.ms/new-console-template for more information

var str = "Cozy lummox gives smart squid who asks for job pen";

// 7.1.1
var dict = new Dictionary<char, int>();

foreach (var s in str.ToUpper())
{
    if ('A' <= s && s <= 'Z')
    {
        if (dict.ContainsKey(s))
            dict[s]++;
        else
            dict[s] = 1;
    }
}

var result1 = dict.OrderBy(x => x.Key);
foreach (var r in result1)
{
    Console.WriteLine($"'{r.Key}':{r.Value}");
}

// 7.1.2
var sortedDict = new SortedDictionary<char, int>();
foreach (var s in str.ToUpper())
{
    if ('A' <= s && s <= 'Z')
    {
        if (sortedDict.ContainsKey(s))
            sortedDict[s]++;
        else
            sortedDict[s] = 1;
    }
}

foreach (var r in sortedDict)
{
    Console.WriteLine($"'{r.Key}':{r.Value}");
}