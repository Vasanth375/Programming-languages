using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //creation of threads
       Thread t1 =new Thread(m2);
       Thread t2 =new Thread(m2);
       Thread t3 =new Thread(m2);
       
       //setting thread priorities 
       t2.Priority=ThreadPriority.Highest;
       t1.Priority=ThreadPriority.Lowest;
       
       //getting started
       t1.Start();
       t2.Start();
       t3.Start();
       
       //displaying all thread priorities
       Console.WriteLine("{0}",t2.Priority);
       Console.WriteLine("{0}",t3.Priority);
       Console.WriteLine("{0}",t1.Priority);
     }
     
     static void m2()
     {
       for(int i=0;i<4;i++)
       {
         Console.WriteLine("i value :"+i);
         Thread.Sleep(1000);
       }
     }
     //output maybe different between
     //every time we run the program CPU can change
     //its scheduling Algorithm
   }
 }
