using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class MethodsFromNETLib
    {
        public static void RandomTest()
        {
            // System.Random
            Random dice = new Random();
            // we create a new instance of System.Random and assign it to dice
            int roll = dice.Next(1, 7);
            // we call on the Next() method of System.Random and pass it a min and a max.
            Console.WriteLine(roll);
            // Log our results.
        }
        public static void StateVersusStateless()
        {
            Console.WriteLine("State describes the condition of the execution environment at a specific moment \n" +
                "in time. At any moment during execution, the current state of the application is\n" +
                "the collection of all values stored in memory. \n" +
                "Some methods do not rely on the current state of the application to work properly\n" +
                "These are STATELESS methods. They work by not referencing or changing any values\n" +
                "already stored in memory. They are STATIC METHODS.\n");
            Console.WriteLine("For example Console.WriteLine() is a method that does not rely on stored info \n" +
                "in memory. It performs its function and finishes without impacting the state of the appl. \n" +
                "Stateful methods however must have access to the state of the application to work.\n" +
                "Stateful methods are built in such a way that they rely on values stored in memory by \n" +
                "previous lines of code that have already executed. These are known as INSTANCE METHODS. \n");
        }
        public static void DoWeNeedToCreateNewInstances()
        {
            Console.WriteLine("One way to learn how to call the method is to consult the documentation. - docs.microsoft");
        }
        public static void WorkingWithReturnsAndInputs()
        {
            Console.WriteLine("Some methods are designed to complete their function and end \"quietly\".\n" +
                "They do not return values, ");
            Console.WriteLine("Some methods are designed to accept input values, such as dice.Next(1, 7).\n" +
                "the 1 and 7 are the input parameters, we separate them with a , .");
        }
        public static void OverloadingMethods()
        {
            Console.WriteLine("Many methods in the .NET Class Library have overloaded method signatures.\n\n" +
                "An OVERLOADED METHOD is defined with MULTIPLE METHOD SIGNATURES (int, str). Overloaded \n" +
                "Methods provide different ways to call the method or provide different data types.\n\n" +
                "An example is Console.WriteLine().\n" +
                "Console.WriteLine(number);\n" +
                "Console.WriteLine(text);\n" +
                "Console.WriteLine();\n" +
                "Are all examples of that.");
        }
        public static void OverloadingDice()
        {
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);
            Console.WriteLine($"First roll => {roll1}");
            Console.WriteLine($"Second roll => {roll2}");
            Console.WriteLine($"Third roll => {roll3}");
            Console.WriteLine("Want to know more?\n" +
                "https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=net-6.0");
        }
        public static void UsingDocsForOverloads()
        {
            Console.WriteLine("Notice in Next(int32, int32) that under Parmateres and maxValue it reads:\n" +
                "The exclusive upper bound of the random number returned.\n" +
                "An exclusive upper bound means that if we want numbers no larger than 10, we must pass in\n" + 
                "the value 11.\n");
        }
        public static void Challenge()
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
        }
    }
}
