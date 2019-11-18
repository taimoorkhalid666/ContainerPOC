using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ContainerPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            for (int i = 0; i < 10; i++)
                Trace.TraceInformation("App is working ");

            Console.ReadKey();
        }
    }
}
