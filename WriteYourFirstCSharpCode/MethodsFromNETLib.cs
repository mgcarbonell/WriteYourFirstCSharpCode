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
                "in time. At any moment during execution, the current state of the application is\n " +
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
        }
    }
}
