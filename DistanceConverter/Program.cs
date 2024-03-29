﻿// See https://aka.ms/new-console-template for more information

using DistanceConverter;

if (args.Length >= 1 && args[0] == "-tom")
{
    PrintFeetToMeterList(1, 10);
}
else
{
    PrintMeterToFeetList(1, 10);
}

static void PrintFeetToMeterList(int start, int stop)
{
    for (int feet = start; feet <= stop; feet++)
    {
        double meter = FeetConverter.ToMeter(feet);
        Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
    }
}

static void PrintMeterToFeetList(int start, int stop)
{
    for (int meter = 1; meter <= 10; meter++)
    {
        double feet = FeetConverter.FromMeter(meter);
        Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
    }
}