using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class WorkingWithVariables
    {
        public static void LiteralValues()
        {
            // Why does
            Console.WriteLine('b'); // => 'b'
            // but why does the line of code below return
            // Console.WriteLine('Hello World!');
            // error: Too many characters in character literal
            // '' stores a char, or character. 
            // there are also int literals
            int intLiteral = 123;
            Console.WriteLine(intLiteral); // => 123
            // and decimal literals
            decimal decLiteral = 12.3M;
            Console.WriteLine(decLiteral); // => 12.3
            // and bool literals
            bool boolLiteral = true;
            Console.WriteLine(boolLiteral); // => true
            Console.WriteLine(!boolLiteral); // => false

        }
        public static void WorkingWithVars()
        {
            string firstName; // assigning a variable
            firstName = "Mario"; // "setting" the variable. 
            Console.WriteLine(firstName); // "getting" the variable
        }
        public static void ImplicitlyTypedVars()
        {
            // What is implicit typing? A convenience brought to us by the compiler.
            // We can use var to let the compiler infer its type. 
            var message = "Hello World!";
            Console.WriteLine(message); // => Hello World!
            // the compiler infered I wanted a string.
            // however if I tried to...
            // `message = 10M` and `Console.WriteLine()` it, I would receive an error:
            // CS0029: Cannot implicitly convert type 'decimal' to 'string'
            // Note: We can only use the var keyword IF the variable is initialized.
            // Therefore we cannot do: `var message;` we will receive an error.
        }
        public static void Challenge1()
        {
            // Using two diffrerent techniques to print two lines of output, display the following:
            // This is the first line.
            // This is the second line.
            Console.WriteLine("This is the first line.");
            Console.WriteLine("This is the second line.");
            Console.WriteLine("This is the first line. \nThis is the second line.");
        }

        public static void Challenge2()
        {
            /**
             * Input: Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.
             * store the following values from the output in variables:
             *     Bob
             *     3
             *     34.4
             * Variables should be given names that reflect their purpose.
             * Correct datatypes
             * Combine variables with literal strings passed into a series of Console.Write()
             * commands to form the input message.
             */
            string name = "Bob";
            int messageCount = 3;
            decimal temperature = 34.4M;
            Console.WriteLine($"Hello {name}! You have {messageCount} in your inbox. The temperature is {temperature} celsius.");
        }
    }
}
