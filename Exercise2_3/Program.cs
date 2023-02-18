// See https://aka.ms/new-console-template for more information
using Exercise2_3;

var sales = new SalesCounter("sales.csv");
IDictionary<string, int> amountPerStore = sales.GetPerProductCategorySales();
foreach (KeyValuePair<string, int> obj in amountPerStore)
{
    Console.WriteLine("{0} {1}", obj.Key, obj.Value);
}