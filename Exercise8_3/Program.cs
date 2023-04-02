using Exercise8_3;

var tw = new TimeWatch();

tw.Start();

var sum = 0;
for (int i = 0; i < 100; i++)
{
    for (int j = 0; j < 100; j++)
    {
        sum += j + i;
    }
}

Thread.Sleep(1000);

TimeSpan duration = tw.Stop();
Console.WriteLine($"合計:{sum}");
Console.WriteLine($"処理時間は{duration.TotalMilliseconds}ミリ秒でした");