using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5
/*Delegate : delegate is a reference type 
  variable refer to the method, when an event 
  occurs*/

 namespace Dcoder
 {
   //declaration of delegate
   delegate void even();
   
   //class one
   public class Program
   {
     
     void fun()
     {
       Console.WriteLine("hello fun()");
     }
     
    void display()
    {
       Console.WriteLine("hello display()");
    }
    
     public static void Main(string[] args)
     {
       //creating object for class one
       Program p = new Program();
       
       //creating delegate object added fun()
       even e = new even(p.fun);
       
       //adding display() to delegate object
       e+=p.display;
       
       //calling both methods at once
       e();
       
       //creating object for class two
       csn c=new csn();
       
       //calling public function of class two
       c.function();
     }
     
   }
   
   //class two
   class csn
   {
     
     void fun1()
     {
       Console.WriteLine("hello fun1()");
     }
     
     public void function()
     {
       csn c=new csn();
       even e = new even(c.fun1);
       e();
     }
     
   }
 }
