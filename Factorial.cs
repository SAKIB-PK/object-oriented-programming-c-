// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
namespace Math{
    class FactorialMath{
        static int Factorial(int n){
            if(n == 0){
                return 1;
            }else{
                return n * Factorial(n-1);
            }
        }
        static void Main(string[] args){
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result= {0} ",Factorial(n));
            
        }
    }
}