using System;
using System.Collections.Generic;
using System.Text;

namespace FractionsKata
{
    public class Fraction
    {
        public static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
