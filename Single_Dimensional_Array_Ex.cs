// Demonstrate the use of a single dimensional array.
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace stud{
    class student{
        int id,m1,m2,m3,total,avg;
        string name,res,grade;
        public void get(){
            Console.WriteLine("Enter the Student ID: ");
            id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Mark1, Mark2,Mark3: ");
            m1 = Convert.ToInt16(Console.ReadLine());
            m2 = Convert.ToInt16(Console.ReadLine());
            m3 = Convert.ToInt16(Console.ReadLine());
            
        }
        public void cal(){
            total = m1 + m2+ m3;
            avg = total/3;
            if(m1>=40 && m2 >=40 && m3>=40){
                res = "Passed";
                // Nested if-else condition 
                if(avg >= 80 && avg <=100){
                    grade = "A";
                }else if (avg >=60 && avg <=80){
                    grade = "B";
                }else {
                    grade = "C";
                }

            }else{
                res = "Fail";
                grade = "-";
            }
        }
        public void display(){
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",id ,name,m1, m2,m3,total,avg,res,grade);
        }
    }
    class stude{
        static void Main(string[] args){
            int i , n;
            student[] s = new student[20];
            Console.WriteLine("Enter the no of Student: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n;i++){
                s[i]=new student();
                s[i].get();
                s[i].cal();
            }
            Console.WriteLine("ID\tName\tM1\tM2\tM3\tTotal\tAvg\tResult\tGrade");
            for(i=1;i<=n;i++){
                s[i].display();
            }
            Console.ReadLine();
        }
    }
}