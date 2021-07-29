using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        //normal delegate creation
        public delegate void gate();
        void gate1()
        {
            Console.WriteLine("Gate is opened");
        }
        void gate2()
        {
            Console.WriteLine("Gate is opened earlierly");
        }
        void gate3()
        {
            Console.WriteLine("Gate is opened earlierly");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program.gate del1 = new Program.gate(obj.gate1);
            //Program.gate del2 = new Program.gate(obj.gate2);
            //combining del1 and del2 and head is del1
            //del1 += del2;
            del1 += obj.gate2;
            del1 += obj.gate3;
            del1();
        }
    }
}
