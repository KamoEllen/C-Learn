using System;
using System.Collections.Generic; //works for lists and collevtions
using System.Linq; //works with data
using System.Text; //text and coding
using System.Threading.Tasks; //used for multi threaded apps

namespace ProgrammingMoshHourLong
{
    internal class Program
    {
        static void Main(string[] args) // arggs is a default paameter , void means nothing,c# is case sensitive.

        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f; // had to say f or it'd be seen as decimal
            char character = 'A';
            string firstName = "Kamo";
            bool isWorking = true; //all in blue is keyword


            Console.WriteLine(number); // code snippet cw and tab
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            //var makes varaible declarations easeier , replace byte,int,float such with var, it'd work
        }
    }
}
