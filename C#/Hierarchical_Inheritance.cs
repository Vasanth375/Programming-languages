using System;
namespace ConsoleApplication7
{
    class main
    {
        static void Main()
        {
            father obj = new father();
            obj.name();

            Son son = new Son();
            son.name();
            
            Daughter daughter = new Daughter();
            daughter.name();
            Console.ReadKey();
        }
    }
    class father
    {
        public void name()
        {
            Console.WriteLine("Father_name:-Hopper");
        }
    }
    class Son:father
    {
        public new void name()
        {
            Console.WriteLine("Name:-Max mayfield");
        }
    }
    class Daughter:father
    {
        public new void name()
        {
            Console.WriteLine("Daughter_Name:-Eleven");
        }
    }

    
}
