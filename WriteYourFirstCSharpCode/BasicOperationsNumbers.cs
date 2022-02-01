using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class BasicOperationsNumbers
    {
        public static void SimpleAddition()
        {
            int firstNum = 12;
            int secondNum = 13;
            Console.WriteLine(firstNum + secondNum);
        }
        public static void ForceImplicitConversion()
        {
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets!");
        }
        public static void WhenForcedConversionsFail()
        {
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets!");
            // Rather than radding 7 and 7, it concatenated "7" and 7 to form 77 ala Javascript
        }
        public static void HowToAvoidImplicitFailure()
        {
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets!");
        }
        public static void MathOperations()
        {
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            // how do we see the decimal?
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);
            // Can we mix them? Not really. Can we cast them? Yes. We. Can!
            int first = 7;
            int second = 5;
            decimal secondQuotient = (decimal)first / (decimal)second;
            Console.WriteLine(secondQuotient);
        }
        public static void RemainderAfterIntDivision()
        {
            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));
        }
        public static void OrderOfOperations()
        {
            // PEMDAS
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine("Not using parenthesis can give us an interesting answer => " + value1);
            Console.WriteLine("Using parens and order of operations we'll get another answer => " + value2);
        }
        public static void WhatAboutExponents()
        {
            int num = 2;
            Console.WriteLine($"2 raised to the 2nd power is => {Math.Pow(num, 2)}");
            // => 4
        }
        public static void IncrementAndDecrement()
        {
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
        }
        public static void Challenge()
        {
            // Convert F to C
            // F => C = (F - 32) * (5 / 9)
            int fahrenheit = 94;
            decimal decimalF = fahrenheit;
            decimal convertFtoCelsius = (decimalF - 32m) * (5m / 9m);
            Console.WriteLine($"The temperature is {convertFtoCelsius} Celsius.");
        }
    }
}
