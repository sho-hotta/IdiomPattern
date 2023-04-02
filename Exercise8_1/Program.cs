using System.Globalization;

var now = DateTime.Now;
var culture = new CultureInfo("ja-JP");
culture.DateTimeFormat.Calendar = new JapaneseCalendar();
var dayOfWeek = culture.DateTimeFormat.GetDayName(now.DayOfWeek);

var nowStr1 = now.ToString("yyyy/M/d HH:mm");
var nowStr2 = now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
var nowStr3 = now.ToString($"ggy年 M月d日({dayOfWeek})", culture);

Console.WriteLine(nowStr1);
Console.WriteLine(nowStr2);
Console.WriteLine(nowStr3);