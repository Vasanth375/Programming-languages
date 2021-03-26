using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

//program of internal access specifier 
 namespace Dcoder
 {
   public class Program   //class one
   {
     public static void Main(string[] args)
     {
        program pro=new program();
        //object of class two

        Console.WriteLine(pro.id);
        //printing data of another class
        
        pro.details();
        //calling method of another class
     }
   }
   class program      //class two
   {
     internal int id=68;
     internal void details()
     {
       Console.WriteLine("Hello your id {0}",id);
     }
   }
 }
 /*internal access specifier or mobifier
its scope is within the file only not accessible 
outside of the file*/
