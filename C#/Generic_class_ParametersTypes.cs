/* Generic class with single and multiple parameters*/
using System;

namespace Dcoder
{
    class Base<num,str>
    {
        public num i;
        public str name;
        public void show()
        {
            Console.WriteLine($"Base called {i}");
            Console.WriteLine($"name {name}");
        }
    }
    public class Program
    {
        
       static void Main(string[] args)
       {
            Base<int,string> b = new Base<int,string>();
            b.i = 68;
            b.name = "vasanth";
            b.show();
            
            //single parameter 
            //Base<string> s = new Base<string>();
            //s.i = "vasanth";
            //s.show();
            //on class syntax
            //class Base<str>{ }
        }
    }
}
