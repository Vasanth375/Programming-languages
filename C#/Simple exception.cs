using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] num={10,20,30};
       
       for(int i=0;i<4;i++)
       {
       try
       {
        
         Console.WriteLine(num[i]);//printing all elements
         Console.WriteLine(i/0);//division i/0
         
       }
       catch(Exception w)
       //it checks all exceptions
       //and displays related message
       {
         Console.WriteLine(w.Message);//displays what type of error it is 
       }
    
     }
     
     }
   }
 }
