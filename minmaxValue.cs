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
          
            Console.WriteLine("{0} {1}" , byte.MinValue, byte.MaxValue);
            //0 represent first agument, 1 represents the max. remember byte max is 255
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            // shows us range 
        }
    }
}
