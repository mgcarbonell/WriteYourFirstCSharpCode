using System;

namespace WriteYourFirstCSharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
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
    }
}