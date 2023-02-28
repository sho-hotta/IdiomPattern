// See https://aka.ms/new-console-template for more information

var str1 = Console.ReadLine();
var str2 = Console.ReadLine();

if (String.Compare(str1, str2, ignoreCase:true) == 0){
    Console.WriteLine("等しい");
}
else
{
    Console.WriteLine("異なる");
}