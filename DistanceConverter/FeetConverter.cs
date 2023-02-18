using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public static class FeetConverter
    {
        public static readonly double Ratio = 0.3048;

        public static double ToMeter(double feet)
        {
            return feet * Ratio;
        }

        public static double FromMeter(double meter)
        {
            return meter / Ratio;
        }
    }
}
