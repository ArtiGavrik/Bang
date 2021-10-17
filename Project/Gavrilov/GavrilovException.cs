using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov
{
    class GavrilovException:Exception
    {
        public GavrilovException(string message) : base(message) { }
    }
}
