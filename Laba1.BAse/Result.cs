using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.BAse
{
    internal class Result
    {
        public double A { get; set; }
        public double B { get; set; }
        public Result(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Otvet()
        {
            return A * B;
        }
    }
}
