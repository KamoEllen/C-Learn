using System;
using System.Collections.Generic; //works for lists and collevtions
using System.Linq; //works with data
using System.Text; //text and coding
using System.Threading.Tasks; //used for multi threaded apps

namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args) // arggs is a default paameter , void means nothing,c# is case sensitive.

        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1,7);//highest random num will be 6
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...."); //create space
                System.Threading.Thread.Sleep(1000);



                enemyRandomNum = random.Next(1, 7);//andom integer that is within a specified range.
                Console.WriteLine("Enemy rolled a"  + enemyRandomNum);

                Console.WriteLine("...."); //create space
                System.Threading.Thread.Sleep(1000);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins");
                }
                else if (enemyRandomNum > playerPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins");

                }
                else
                {
                    Console.WriteLine("Tie");
                }
                Console.WriteLine("The score is now Player:" + playerPoints + " Enemy:" + enemyPoints);
                Console.WriteLine("...."); //create space
                System.Threading.Thread.Sleep(1000);

            }
            Console.ReadKey();





        }
    }
}
