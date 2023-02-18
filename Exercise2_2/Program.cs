// See https://aka.ms/new-console-template for more information

using Exercise2_2;

PrintInchToMeterList(1, 10);

static void PrintInchToMeterList(int start, int stop)
{
    for (int inch = start; inch <= stop; inch++)
    {
        double meter = InchConverter.ToMeter(inch);
        Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
    }
}
