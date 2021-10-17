using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov.Gavrilov
{
    class Kvad:Lin
    {
        protected double Discriminant(double a, double b, double c)
        {
            return b * b - (4 * a * c);
        }
        protected double[] Func(int a, int b, int c)
        {
            if (a == 0)
            {
                return Func(b, c);
            }
            double disc = Discriminant(a, b, c);
            if (disc == 0)
            {
                return x = new double[] { -b / (2 * a) };
            }
            if (disc > 0)
            {
                disc = Math.Sqrt(disc);
                return x = new double[]
                {
                    (-b + disc) / (2 * a),
                    (-b - disc) / (2 * a)
                };
            }
            throw new Exception("Корней нет");
        }
    }
}
