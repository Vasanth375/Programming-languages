using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder
 {
   
   class Program2
   {
     //Base class
     public void program2()
     {
       Console.WriteLine("you reached program2()");
     }
   }
   
   class Program1:Program2    //program1(class) inherits program2(class)
   {
        //Derived class
     public void program1()
     {
       Console.WriteLine("you reached program1()");
     }
   }
   
   class Program:Program1    //Program inherits Program1
   {
        //second derived class
     public static void Main()
     {
      /*we created object to second derived class
        using inheritance we can access other 
        classes(inherited class) without creating object*/
       Program Pro=new Program();
      
       //accessing other methods in classes without creating object
       Pro.program1();
       Pro.program2();
     }
   }
   
 }
