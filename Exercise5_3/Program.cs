// See https://aka.ms/new-console-template for more information

using System.Text;

var str = "Jackdaws love my big sphinx of quartz";

// 5.3.1
Console.WriteLine(str.Count(s => s == ' '));

// 5.3.2
Console.WriteLine(str.Replace("big", "small"));

// 5.3.3
Console.WriteLine(str.Split(' ').Length);

// 5.3.4
str.Split(' ').Where(s => s.Length <= 4 ).ToList().ForEach(s => Console.WriteLine(s));

// 5.3.5
var strArray = str.Split(" ");
var strCopy = new StringBuilder();

strCopy.AppendJoin(' ', strArray);

Console.WriteLine(strCopy.ToString());