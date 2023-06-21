using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationTesting
{
    public static class QuadraticEquation
    {
        public static double[] Solve(double a, double b, double c)
        {
            if (a.Equals(double.NaN) || b.Equals(double.NaN) || c.Equals(double.NaN)) 
            {
                throw new Exception("a, b and c should be a numbers");
            }

            if (Math.Abs(a) - double.Epsilon <= 0) 
            {
                throw new Exception("a cant be 0");
            }

            double discriminant = Math.Pow(b,2) - 4 * a * c;

            if (Math.Abs(discriminant) < 1e-15)
            {
                return new double[] { -b / (2 * a) };
            }
            else if (discriminant > 0)
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDiscriminant) / (2 * a);
                double root2 = (-b - sqrtDiscriminant) / (2 * a);
                return new double[] { root1, root2 };
            }
            else
            {
                return Array.Empty<double>();
            }
        }
    }
}
