using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov
{
    class Lin
    {
        protected List<float> x;
        public List<float> Check(float a, float b)
        {
            if (a == 0)
                return null;
            return x = new List<float>() { -b / a };
        }
    }
}
