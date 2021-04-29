using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder
 {
   public class Program<T>
   {
     public void show<T>(T data)
     {
       
       Console.WriteLine(data);
      
     }
   }
   class library
   {
     public static void Main()
     {
       
       //creating generic object for only int data types
      Program<int> obj=new Program<int>();
      
      obj.show(68);
      //calling another function with string parameter
      obj.show<string>("vasanth");
    
     }
   }
 }
