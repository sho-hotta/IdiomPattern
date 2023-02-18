using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2
{
    public static class InchConverter
    {
        public static readonly double Ratio = 0.0254;

        public static double ToMeter(double inch)
        {
            return inch * Ratio;
        }
    }
}
