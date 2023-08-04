using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADEL
{
    public delegate void PrintMessage(string message);
    internal class AnonMethods
    {
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine(message);
            };
            printMessage("Hello from inside Print Message");
        }
    }
}
