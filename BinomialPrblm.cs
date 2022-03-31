// Algorithm
/*
1. Read a,b,c
2. d = b^2 -4ac
3. if d<0 then, print "Roots are imaginary"
4. if d=0 then, 
    d = -b/2a then,
    print "x value is {d}
5. if d>0 then 
    x1 = -b+root-d/2a
    x2 = -b-root-d/2a
    print "x1 value and x2"
6. exit
*/

// code - 10.03.22
using System;
namespace Binomial{
    class BinomialProblem{
        static void Main(string[] args){
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double d = (b*b)-4*a*c;
            if(d>0){
                double x1 = (-b+ Math.Sqrt(d))/2*a;
                double x2 = (-b- Math.Sqrt(d))/2*a;
                Console.WriteLine("X1 value is {0}.",x1);
                Console.WriteLine("X2 value is {0}.",x2);   
            }else{
                if(d==0){
                    double x = -b/2*a;
                    Console.WriteLine("X value is {0}",x);  
                }else{
                    Console.WriteLine("Roots are Imaginary Number.");
                }
            }
        }
    }
}