using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class ReadableCode
    {
        public static void VariableExamples()
        {
            char userOption;

            int gameScore;

            float particlesPerMillion;

            bool processedCustomer;
            Console.WriteLine("char userOption;\nint gameScore;\nfloat particlesPerMillion;\nbool processedCustomer;");
        }
        public static void TodoExample()
        {
            // TODO
            // use sparingly but TODOs will appear in the task list. Ctrl + \, T
        }
        public static void BadExampleOfComments()
        {
            Random random = new Random();
            string[] orderIDs = new string[5];
            // Loop through each blank orderID
            for (int i = 0; i < orderIDs.Length; i++)
            {
                // Get a random value that equates to ASCII letters A through E
                int prefixValue = random.Next(65, 70);
                // Convert the random value into a char, then a string
                string prefix = Convert.ToChar(prefixValue).ToString();
                // Create a random number, padd with zeroes
                string suffix = random.Next(1, 1000).ToString("000");
                // Combine the prefix and suffix together, then assign to current OrderID
                orderIDs[i] = prefix + suffix;
            }
            // Print out each orderID
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
        }
        public static void GoodExampleOfComments()
        {
            /*
            The following code creates five random OrderIDs
                to test the fraud detection process.  OrderIDs 
                consist of a letter from A to E, and a three
                digit number. Ex. A123.
            */
            Random random = new Random();
            string[] orderIDs = new string[5];

            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");

                orderIDs[i] = prefix + suffix;
            }

            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
        }
        public static void ChallengeOriginal()
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            // convert the message into a char array
            char[] charMessage = str.ToCharArray();
            // Reverse the chars
            Array.Reverse(charMessage);
            int x = 0;
            // count the o's
            foreach (char i in charMessage) { if (i == 'o') { x++; } }
            // convert it back to a string
            string new_message = new String(charMessage);
            // print it out
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");
        }
        public static void ChallengeRefactor()
        {
            /*
            The following code reverses a message and counts the number of
            times a character appears. It then prints the results to the
            console.
             */
            string str = "The quick brown fox jumps over the lazy dog.";
            char[] charMessage = str.ToCharArray();
            int count = 0;

            Array.Reverse(charMessage);

            foreach (char letter in charMessage) 
            { 
                if (letter == 'o') 
                { 
                    count++; 
                } 
            }

            string new_message = new String(charMessage);
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {count} times.");


        }
        public static void ChallengeDocSolution()
        {
            /*
               This code reverses a message, counts the number of times 
               a particular character appears, then prints the results
               to the console window.
             */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }
    }
}
