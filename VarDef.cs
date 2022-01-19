using System;
namespace Variable
{
    class VariableDef{
        static void Main(string[] args){
            short a;
            int b;
            double d;
            Console.Write("Please input First Number : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Please input Second Number: ") ;
            b = Convert.ToInt32(Console.ReadLine());
            d = a + b;
            Console.WriteLine("a= {0} , b ={1}, c= {2}", a,b,d); 


        }
    }
}