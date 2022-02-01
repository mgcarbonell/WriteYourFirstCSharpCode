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
    }
}
