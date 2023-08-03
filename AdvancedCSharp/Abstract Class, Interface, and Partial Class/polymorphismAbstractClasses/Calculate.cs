using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismAbstractClasses
{
    static class Calculate
    {
        static int count = 0;
        static Calculate()
        {
            count = 0;
        }

        public static void Increment()
        {
            count++;
        }

        public static void Decrement()
        {
            count--;
        }

        public static void ShowValue()
        {
            Console.WriteLine(count);
        }
    }
}
