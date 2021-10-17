using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov
{
    class Lin
    {
        public List<float> x;
        public List<float> Check(float b, float c)
        {
            if (b == 0)
                throw new GavrilovException("Определено, что такое уравнение не существует"); //Исключение
            GavrilovLog.I().Log("Определено, что это линейное уравнение");
            return x = new List<float>() { -c / b };
        }
    }
}
