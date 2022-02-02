using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class ArraysAndIteration
    {
        public static void DeclaringArrays()
        {
            string[] fraudulentOrderIDs = new string[3];
            /*^      ^                    ^   ^      ^
             * type  variable name        new type   number of elements array will contain.
             * What's going on? We're delcaring a new array! Remember the new keyword?
             * This time we're saying "I want an NEW array of strings, with a length of 3."
             * 
             */
            int[] numbers = new int[3];
            /* Just like this will create an array called numbers that will contain 3 ints.
             * Okay, let's add stuff!
             */
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            /* What happens if we try to add a #4?
             * System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation. ---> System.IndexOutOfRangeException: Index was outside the bounds of the array.
             */
            Console.WriteLine($"First [0th] => {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second [1st] => {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third [2nd] => {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        }
        public static void DeclaringArraysContinued()
        {
            /* Let's take a look at another approach as well.
             */
            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
            Console.WriteLine($"First [0th] => {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second [1st] => {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third [2nd] => {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        }
        public static void foreachStatement()
        {
            string[] names = { "Bob", "Conrad", "Grant" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                //Console.WriteLine($"There are {item} in stock");
                bin++;
                sum += items;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"Inventory total => {sum}");
        }
        public static void ChallengeExplanation()
        {
            Console.WriteLine("Previously, we set out to write code that would store Order IDs belonging to potentially fraudulent orders.\n" +
                "Our hope is to find fraudulent orders as early as possible and flag them for deeper analysis.\n\n" +
                "Our team found a pattern. Orders that start with the letter \"B\" encounter fraud 25 times the normal rate.\n" +
                "We will write new code that will output the Order ID of new orders where the Order ID starts with the letter\n" +
                "\"B\". This will be used by our fraud team to investigate further.");
        }
        public static void Challenge()
        {
            string[] fakeOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach (string fakeID in fakeOrderIDs)
            {
                if (fakeID.StartsWith("B"))
                {
                    Console.WriteLine($"Order beginning with B detected: {fakeID}");
                }
            }
        }
        public static void ChallengeUsingForLoop()
        {
            string[] fakeOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            for (int i = 0; i < fakeOrderIDs.Length; i++)
            {
                if (fakeOrderIDs[i].StartsWith("B"))
                {
                    Console.WriteLine($"Order beginning with B detected: {fakeOrderIDs[i]}");
                }
            }
        }
        public static void ChallengeSolutionDocs()
        {
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }
        }
    }
}
