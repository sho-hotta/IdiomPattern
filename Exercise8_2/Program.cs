Console.WriteLine(NextDay(DateTime.Today, DayOfWeek.Monday));

static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek)
{
    var days = (int)dayOfWeek - (int)(date.DayOfWeek);
    return date.AddDays(days + 7);
}