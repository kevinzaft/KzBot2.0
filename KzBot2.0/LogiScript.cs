using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KzBot2
{
    public static class LogiScript
    {
        public static void Start()
        {
            while (true)
            {
                ScriptMethods.TakeFormationScreenShot();
                ScriptMethods.RestartLogis();
                Thread.Sleep(10000);
            }
        }
    }
}
