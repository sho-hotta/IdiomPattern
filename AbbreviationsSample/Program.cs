// See https://aka.ms/new-console-template for more information

using AbbreviationsSample;

// コンストラクタ呼び出し
var abbrs = new Abbreviations();

Console.WriteLine($"登録されている用語の数は{abbrs.Count}個です");

// Addメソッドの呼び出し例
abbrs.Add("IOC", "国際オリンピック委員会");
abbrs.Add("NPT", "核兵器不拡散条約");

// 7.2.3
Console.WriteLine($"登録されている用語の数は{abbrs.Count}個です");
abbrs.Remove("NPT");
Console.WriteLine($"登録されている用語の数は{abbrs.Count}個です");
abbrs.Remove("NP");
Console.WriteLine($"登録されている用語の数は{abbrs.Count}個です");

// インデクサの利用例
var names = new[] { "WHO", "FIFA", "NPT" };
foreach (var name in names)
{
    var fullName = abbrs[name];
    if (fullName == null)
        Console.WriteLine($"{name}は見つかりません");
    else
        Console.WriteLine($"{name}={fullName}");
}
Console.WriteLine();

// ToAbbreviationメソッドの利用例
var japanese = "東南アジア諸国連合";
var abbreviation = abbrs.ToAbbreviation(japanese);
if (abbreviation == null)
    Console.WriteLine($"{japanese}は見つかりません");
else
    Console.WriteLine($"「{japanese}」の略語は{abbreviation}です");
Console.WriteLine();

// FindAllメソッドの利用例
foreach (var item in abbrs.FindAll("国際"))
{
    Console.WriteLine($"{item.Key}={item.Value}");
}
Console.WriteLine();

foreach (var item in abbrs.GetThreeLettersAbbreviation())
{
    Console.WriteLine($"{item.Key}={item.Value}");
}
Console.WriteLine();