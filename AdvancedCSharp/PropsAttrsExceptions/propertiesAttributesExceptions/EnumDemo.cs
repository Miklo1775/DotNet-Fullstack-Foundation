using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesAttributesExceptions
{
    enum WeekDays: byte
    {
        Monday = 10,     //0
        Tuesday = 11,    //1
        Wednesday = 12,  //2
        Thursday,   //3
        Friday,     //4
        Saturday,   //5
        Sunday      //6
    }

    internal class EnumDemo
    {
        public void Display()
        {
            //to get the INT value of enum, use typecasting

            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
        }
    }
}
