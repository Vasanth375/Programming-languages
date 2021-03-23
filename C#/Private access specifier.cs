using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

//program to see private specifier
 namespace Dcoder
 {
   class Android1
   {
     //int a=3;
     // by default class data/methods are private
     //so we won't declare private specially

     void app1()
     {
       int a=2;
       Console.WriteLine(a);
     }
     
     static void Main()
     {
      Android1 obj=new Android1();
      obj.app1();
      //calling app1() within class
      
      Android2 obj1=new Android2();
      obj1.app2();
      //calling app2() outside of class
     }
   }
   class Android2
   {
    void app2()
    {
       //inaccessible due to protection level
     }
   }
   
 }//end of namespace 
 
 /*to avoid errors in this program set android2
creating object statement you have to put in 
comments*/
