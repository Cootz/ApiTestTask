using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestTask.Core.Helpers
{
    public static class MathHelper
    {
        public static double ToRadians(this double value) => value * Math.PI / 180;

        public static (double, double) GetSinCosFor(double value)
        {
            double cos = Math.Cos(value);
            double sin = Math.Sin(value);

            return (sin, cos);
        }
    }
}
