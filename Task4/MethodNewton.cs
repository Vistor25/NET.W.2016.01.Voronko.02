using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MethodNewton
    {
        public static double SqrtByNewtonMetod(double A, double n, double e = 0.000000001)
        {
            if (n<=0||e>1)
                throw new ArgumentException();
            double x0 = A/n;
            double x1 = 1/n*((n - 1)*x0 + A/Math.Pow(x0, n - 1));
            while (Math.Abs(x1-x0)>e)
            {
                x0 = x1;
                x1= 1 / n * ((n - 1) * x0 + A / Math.Pow(x0, n - 1));
            }

            return x1;
        }
    }
}
