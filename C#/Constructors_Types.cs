using System;

namespace Practise
{
    class student
    {
        public string Name;
        public int Id;
        public void set(string n, int i)
        {
            Name = n;
            Id = i;
        }

        public void get()
        {
            Console.WriteLine("Name :-" + Name);
            Console.WriteLine("ID   :-" + Id);
        }

        public student(string i, int n)
        {
            Name = i;
            Id = n;
        }

        public student(student temp)
        {
            temp.Id = 11;
        }
        static student()
         //static constructor can called when a first instance is called by that class
        {
            Console.WriteLine("static constructor claed");
        }
    }

    class Program
    {
        static int a = 3;
        static string name = "sai";  //static variables means without object reference we can call it

        static void Main(string[] args)
        {
            Console.WriteLine("Parameterized constructor and process code ");
            student sobj = new student("/0", 0);

            sobj.set("Vasanth", 68);
            sobj.get();
            Console.WriteLine("Program instance variables");
            Console.WriteLine(a + " " + name);

            Console.WriteLine("Copy constructor ");
            student cobj = new student(sobj);///copy constructor it passess the original copy of the object
            sobj.get();
            Console.ReadKey();
        }
    }
}
