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

            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("welcom to num guess game");
            Console.WriteLine("1-10 will be generated");
            Console.WriteLine("If u guess correct , u win");

            //Console.WriteLine(randomNum); , test

            while(!isCorrectGuess) //deny its truth , if its false contine the loop until its true
            {
                Console.WriteLine("Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high");

                }
                else if(guess < randomNum)
                        {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Correct");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("You have won!");
            Console.ReadKey();





        }
    }
}
