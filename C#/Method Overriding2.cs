using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder
 {
   class baseclass
   {
     public virtual void pop()
     {
       Console.WriteLine("baseclass");
     }
   }
   class subclass:baseclass
   {
     public override void pop()
     {
       Console.WriteLine("subclass");
     }
   }
   class derived: subclass
   {
     public override void pop()
     {
       Console.WriteLine("derived");
     }
   }
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
        baseclass B=new baseclass(); 
        //creating object for baseclass
        B.pop();

       //subclass S=new subclass(); 
        baseclass S=new subclass();
        S.pop();
      
       //creating object for subclass
        subclass D=new derived();
        D.pop();
     }
   }
 }
