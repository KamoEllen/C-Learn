using System;
using System.Collections.Generic; //works for lists and collevtions
using System.Linq; //works with data
using System.Text; //text and coding
using System.Threading.Tasks; //used for multi threaded apps

namespace CombatGame
{
    internal class Program
    {
        static void Main(string[] args) // arggs is a default paameter , void means nothing,c# is case sensitive.

        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5; //both start at same 

            Random random = new Random();

            while(playerHp > 0  && enemyHp > 0)
            {
                //Player turn
                Console.WriteLine("--Player Turn  ---");

                Console.WriteLine("Player Hp - "  + playerHp + ". Enemy Hp - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack and 'h' to heal");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHp -= playerHp; // enemyHp = enemyHp- playerAttack
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");

                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }
                //Enemy Turn
                if(enemyHp > 0)
                {
                    Console.WriteLine("--Enemy Turn  ---");
                    Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHp -= enemyHp; // enemyHp = enemyHp- playerAttack
                        Console.WriteLine("Enemy attack enemy and deals " + enemyAttack + " damage!");

                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }
            if(playerHp > 0)
            {
                Console.WriteLine("Congats you have won");
            }
            else
            {
                Console.WriteLine("You Lost");
            }






        }
    }
}
