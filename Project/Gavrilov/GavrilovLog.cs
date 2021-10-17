using System;
using System.Collections.Generic;
using System.Text;

namespace Gavrilov
{
    class GavrilovLog : LogAbstract, LogInterface
    {
        private static GavrilovLog instance;
        List<string> ListArr = new List<string>();
        public static GavrilovLog I()
        {
            if (instance == null)
                instance = new GavrilovLog();
            return instance;
        }
        public LogInterface Log(string str)
        {
            ListArr.Add(str);
            return this;
        }
        public LogInterface Write()
        {
            writeConsole(ListArr.ToArray());
            return this;
        }
    }
}
