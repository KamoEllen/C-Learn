using System;
using System.Collections.Generic; //works for lists and collevtions
using System.Linq; //works with data
using System.Text; //text and coding
using System.Threading.Tasks; //used for multi threaded apps

namespace Calculatorr
{
    internal class Program
    {
        static void Main(string[] args) // arggs is a default paameter , void means nothing,c# is case sensitive.

        {
            int num1;
            int num2;

            int result;
            string answer;
            

            Console.WriteLine("Hello calculator");
            Console.WriteLine("Please enter your first number"); //ask user for their info, store in varaible.

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2);

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition , s for subtraction , m for multiplication , d forr division");
            
            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }

            else if (answer == "s")
            {
                result = num1 - num2;

            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using the app");
            Console.ReadKey(); //lets program wait for a key before it closes


        }
    }
}
