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

            string answer;
            float result;

            Console.WriteLine("WHat shape do u want to find area of");
            Console.WriteLine();

            answer = Console.ReadLine();

            if(answer == "r")
            {
                Console.WriteLine("Please enter height of rectangle");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter width");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else
            {
                Console.WriteLine("Please enter radius of cicle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);

            }
            Console.WriteLine("result is " + result);
            Console.ReadKey();





        }
    }
}
