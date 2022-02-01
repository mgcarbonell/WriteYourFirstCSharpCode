using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteYourFirstCSharpCode
{
    internal class ControlFlowIfElseElseif
    {
        public static void GameOne()
        {
            Random dice = new Random();
            // simulate rolling three 6-sided dice
            int dice1 = dice.Next(1, 7);
            int dice2 = dice.Next(1, 7);
            int dice3 = dice.Next(1, 7);
            int points = 0;
            /*
             * Rules:
             * If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
             * If all three dice you roll result in the same value, you get six bonus points for rolling triples.
             * If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game.
             * Otherwise, you lose.
             */
            int diceToss = dice1 + dice2 + dice3;
            Console.WriteLine($"{diceToss} = {dice1} + {dice2} + {dice3}");
            if ((dice1 == dice2) || (dice2 == dice3) || (dice1 == dice3))
            {
                points += 2;
            } 
            if ((dice1 == dice2) && (dice1 == dice3))
            {
                points += 6;
            }
            if (diceToss + points >= 15)
            {
                Console.WriteLine($"You win with a score of {diceToss + points}");
            }
            else
            {
                Console.WriteLine($"Loser. Your total was {diceToss + points}");
            }

            //if (dice1 == dice2)
            //{
            //    points += 2;
            //}
        }
        public static void GameOneRefined()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
        }

        public static void Challenge()
        {
            /*
             * You've been asked to add a feature to your company's software. The feature is intended to improve the
             * renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs
             * into the software system and is notified their subscription will soon end. You'll need to add a couple of
             * decision statements to properly add branching logic to the application to satisfy the requirements.
             * 
             * You must use all of the variables in your code.
             * 
             * Rule 1: If the user's subscription will expire in 10 days or less display the message:
             * Your subscription will expire soon. Renew now!
             * 
             * Rule 2. If the user's subscription will expire in five days or less, display the messages:
             * Your subscription expires in _ days.
             * Renew now and save 10%!
             * 
             * Rule 3. If the user's subscription will expire in one day, display the message:
             * Your subscription expires within a day!
             * Renew now and save 20%!
             * 
             * Rule 4. If the user's subscription has expired, display the message:
             * Your subscription has expired.
             * 
             * Rule 5. If the user's subscription doesn't expire in 10 days or less, display nothing.
             */
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration < 10)
            {
                if (daysUntilExpiration < 5 && daysUntilExpiration > 1)
                {
                    discountPercentage = 10;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
                }
                else if (daysUntilExpiration == 1)
                {
                    discountPercentage = 20;
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
                }
                else if (daysUntilExpiration == 0)
                {
                    Console.WriteLine("Your subscription has expired.");
                }
                else
                {
                    Console.WriteLine("Your subscription will end soon. Renew now!");
                }
            }
        }
        public static void ChallengeSolutionFromDocs()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
        }
    }
}
