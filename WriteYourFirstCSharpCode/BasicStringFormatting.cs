using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class BasicStringFormatting
    {
        public static void EscapeSequences()
        {
            Console.WriteLine("Hello\nWorld!"); 
            // => \n escape sequence for new line
            Console.WriteLine("Hello\tWorld!"); 
            // => \t escape sequence for tab
            Console.WriteLine("Hello \"World\"!"); 
            // => \" escape for quotes
            // C# reserves \ for escape sequences. So how can we use \ for file paths?
            // escape the escape \\
            Console.WriteLine("c:\\source\\repos");
        }

        public static void FormattingUsingEscape()
        {
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
        }

        public static void VerbatimStringLiterals()
        {
            Console.WriteLine(@"  c:\source\repos
                (this is where your code goes)");
        }
        public static void FormatingWithVerbatims()
        {
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.WriteLine(@"c:\invoices");
        }
        public static void UnicodeEscapeChars()
        {
            // Kon'nichiwa World
            // Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // note will not display because the console does not support UTF-16.

        }
        public static void StringConcatenation()
        {
            string firstName = "Bob";
            string lastName = "Burger";
            string greeting = "Hello welcome to ";
            //string message = greeting + firstName + "'s " + lastName +"s";
            // Avoid intermediate variables
            Console.WriteLine(greeting + firstName + "'s " + lastName + "s!");
        }
        public static void StringInterpolation()
        {
            string firstName = "Bob";
            string message = $"Hello {firstName}! Do you have my rent?";
            Console.WriteLine(message);
        }
        public static void PuttingItAllTogether()
        {
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }
        public static void Challenge()
        {
            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine($"View English Output:\n\tc:\\Exercise\\{projectName}\\data.txt\n\n{russianMessage}\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");
            // note will not display because the console does not support UTF-16.
        }
    }
}
