using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov
{
    interface LogInterface
    {
        LogInterface Log(string str);
        LogInterface Write();
    }
}
