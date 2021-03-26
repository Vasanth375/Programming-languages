using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5
 
/*program to display the data of one private
data member of class in another class*/
  
 namespace Dcoder
 {
   class Program     //class one
   {
     string name;
     int num=12;
     static void Main(string[] args)
     {
       Program obj1=new Program(); //creating object for Program class
       //class one object
      
       obj1.name="Vasanth";
       //if we assign a value to a global data its scope is within the function only 
      // not reused in other methods or another class
       
       program1 obj=new program1();  //creating object for program class
       //class two object
       obj.display(obj1.name);
       //passing class one private data to another class
       
       program2 obj2=new program2();
       //class three object
       obj2.run(obj1.num);
      
       obj1.fun();
       //this a simple program fun()
     }
     void fun()
     {
       Console.WriteLine(num);
       //if we assign value in global variable it is possible to access anywhere
     }
   }
   
   class program1     //class two
   {
     public void display(string n)
     {
       Console.WriteLine(n);
       //printing string
     }
   }
   class program2     //class three
   {
     public void run(int n)
     {
       Console.WriteLine(n);
       //printing integer
     }
   }
 }
