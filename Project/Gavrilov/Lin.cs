using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov.Gavrilov
{
    class Lin
    {
        protected double[] x;
        public double[] Func(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("Нет корней");
            }
            return x = new double[] { (-b / a) };
        }
    }
}
