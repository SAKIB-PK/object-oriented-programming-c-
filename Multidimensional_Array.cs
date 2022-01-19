using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Array{
    class Multi_Dimensional{
        static void Main(string[] args){
            int i,j;
            string[,] subject = new string[3,3];
            for(i=0;i<3;i++){
                for(j=0;j<3;j++){
                    Console.Write("\nEnter Book name for {0}.Row and {1}.Column:\t",i+1,j+1);
                    subject[i,j] = Console.ReadLine();
                }
            };
            Console.WriteLine("\n\n =============================");
            Console.WriteLine("All the element of Books array is : \n\n");
            // Formating output
            Console.Write("\t1\t2\t3\n\n");
            // outer loop for accesing rows
            for(i=0;i<3;i++){
                Console.Write("{0}\t",i+1);
                for(j=0;j<3;j++){
                    Console.Write("{0}\t",subject[i,j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n=============================");
            Console.ReadKey();
        }
    }
}