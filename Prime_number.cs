using System;
namespace Number{
    class Prime{
        static void isPrime(){
            for(int i=2;i<101;i++){
                if(!(i%2==0) || i==2){
                    int ctr = 0;
                    for(int j=2;j<i;j++){
                        if((i%j==0)){
                            ctr++;
                            break;
                        }
                    }
                    if(ctr==0 ){
                        Console.Write("{0} \t",i);
                    }
                }
            }
        }
        static void Main(string[] args){
            Console.Write("\n\n 1 to 100 prime Number finding Program\n");
            Console.WriteLine("----------------------------------------");
            Console.Write("Result: ");
            isPrime();
        }
}   }