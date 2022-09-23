// See https://aka.ms/new-console-template for more information

using WordsExtractorSample;

var lines = File.ReadAllLines("sample.txt");
var we = new WordsExtractor(lines);
foreach (var word in we.Extract())
{
    Console.WriteLine(word);
}
