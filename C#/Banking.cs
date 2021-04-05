using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   class ATM
   {
     public string name;
     private ulong account_number;
     private string password;
     private uint pin;
     public uint balance=500;
     
     void login()       //login method
     {
       Console.WriteLine("enter account number\n");
       account_number=(ulong)Convert.ToInt64(Console.ReadLine());
       /*here you get some tricky right-
        Note:-readline() method always returns string
        first i convert input into long then after converted it again
        long into ulong (I can't convert directly string to ulong its raises an error)*/
       
       Console.WriteLine("enter the passwordn\n");
       password=Console.ReadLine();
       
       Console.WriteLine("Successful logined");
     }
     
     void check_balance()      //checking balance method
     {
       Console.WriteLine(balance+" is your current account balance");
     }
     
     void deposit()
     {
       Console.WriteLine("enter the amount you want to deposit\n");
       uint amount=(uint)Convert.ToInt32(Console.ReadLine());
       balance=amount+balance;
       Console.WriteLine("current balance is "+balance);
     }
     
     void withdrawal()
     {
       Console.WriteLine("enter the amount you want to withdrawal\n");
       uint amount=(uint)Convert.ToInt32(Console.ReadLine());
       if(amount > balance)
       {
         Console.WriteLine("insufficient funds");
       }
       else
       {
         balance=balance - amount;
         Console.WriteLine("your successfully completed your transaction");
         Console.WriteLine("After withdraw your current balance is "+balance);
       }
     }
     
     public static void Main(string[] args)   //Main method
     {
       ATM obj=new ATM();
       obj.login();
       Console.WriteLine("enter 'YES' if you want to check balance\n");
       string check=Console.ReadLine();
       if(check=="YES"||check=="yes")
       {
         obj.check_balance();
       }
       
       Console.WriteLine("enter 'YES' if you want to deposit money \n");
       string dep=Console.ReadLine();
       if(dep=="YES"||dep=="yes")
       {
         obj.deposit();
       }
       
       Console.WriteLine("enter 'YES' if you want to withdrawal money \n");
       string draw=Console.ReadLine();
       if(draw=="YES"||draw=="yes")
       {
         obj.withdrawal();
       }
     }
   
   }
 }
