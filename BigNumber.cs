using System;
namespace BigNum{
    class BigNumber{
        static void Main(string[] args){

            Console.WriteLine("Please Input Three Number.");
            int a = Convert.ToInt16(Console.ReadLine()) ;
            int b = Convert.ToInt16(Console.ReadLine()) ;
            int c = Convert.ToInt16(Console.ReadLine()) ;
            if(a>b && a>c){
                Console.WriteLine("Big Number is {0}", a);
            }else if(b>a && b>c){
                Console.WriteLine("Big Number is {0}", b);
            }else{
                Console.WriteLine("Big Number is {0}", c);
            }
            Console.ReadLine();
        }
    }
}