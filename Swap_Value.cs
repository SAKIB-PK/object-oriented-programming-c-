using System;
namespace Practice{
    class PracticeProblem{
        static  void Main(string[] args){
            int a  =Convert.ToInt32(Console.ReadLine());
            int b  =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swaping a= {0}.",a);
            Console.WriteLine("Before Swaping b= {0}.",b);
            int temp = a;
            a = b;
            b = temp ;
            Console.WriteLine("After Swaping a= {0}.",a);
            Console.WriteLine("After Swaping b= {0}.",b);


        }
    }
}