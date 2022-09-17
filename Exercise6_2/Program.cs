// See https://aka.ms/new-console-template for more information

using Exercise6_2;

var books = new List<Book>
{
    new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
    new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
    new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
    new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
    new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
    new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
    new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
};


// 6.2.1
var result1 = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
Console.WriteLine($"価格：{result1.Price}  ページ数：{result1.Pages}");


// 6.2.2
var result2 = books.Count(x => x.Title.Contains("C#"));
Console.WriteLine($"タイトルにC#が含まれている書籍数：{result2}");


// 6.2.3
var result3 = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
Console.WriteLine($"タイトルにC#が含まれている書籍のページ数平均：{result3}");


// 6.2.4
var result4 = books.FirstOrDefault(x => x.Price >= 4000);
Console.WriteLine($"4000円以上の最初の本：{result4.Title}");


// 6.2.5
var result5 = books.Where(x => x.Price < 4000).Max(x => x.Pages);
Console.WriteLine($"4000円未満の本の最大ページ数：{result5}");


// 6.2.6
var result6 = books.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
foreach (var item in result6)
{
    Console.WriteLine($"{item.Title}：{item.Price}");
}


// 6.2.7
var result7 = books.Where(x => x.Title.Contains("C#")).Where(x => x.Pages <= 500);
foreach (var item in result7)
{
    Console.WriteLine(item.Title);
}