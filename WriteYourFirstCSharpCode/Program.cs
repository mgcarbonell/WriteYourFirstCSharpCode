using System;

namespace WriteYourFirstCSharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge1();
            LiteralValues();
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
    }
}