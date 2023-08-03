using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesAttributesExceptions
{
    internal class Calculation
    {
        public static void Calculate(int num1, int num2) 
        {
            int result = 0;
            try
            {
            result = num1 / num2;
            Console.WriteLine(result);

            }
            catch (Exception e) 
            {
                Console.WriteLine("Oh noes");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute :D");
                Console.WriteLine(result);
            }
        }

        public static void ReCalculate()
        {
            int num1, num2, result = 0;
            try
            {
                Console.WriteLine("Enter first number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Why would you do that? D:");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That needs to be a number! ");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured!!!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am still being executed :D");
                Console.WriteLine(result);
            }
        }
    }
}
