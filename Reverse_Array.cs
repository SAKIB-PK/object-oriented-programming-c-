using System;
using static System.Console;
using static System.Math;
namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "Sunday";
            switch(date){
                case "Saturday":
                    WriteLine("Today is Saturday");
                    break;
                case "Sunday":
                    WriteLine("Today is Sunday");
                    break;
                case "Monday":  
                    WriteLine("Today is Monday");
                    break;
                case "Tuesday": 
                    WriteLine("Today is Tuesday");
                    break;

                default:
                    WriteLine("Today is not a weekday");
                    break;
            }
        }
    }
    
}