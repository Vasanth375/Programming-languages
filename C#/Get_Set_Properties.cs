using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class student
    {
        private
            int num=34;
        public int n;
        public int Num
        {
            set
            {
                n = value;
                num = value;
            }
            get
            {
                return n;
            }

        }
               
        public student()
        {
            Console.WriteLine("Constructor called");
        }
        ~student()
        {
            Console.WriteLine("Destructor called");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            student obj = new student();
            obj.Num = 12;
            Console.WriteLine(obj.n);
            Console.WriteLine(obj.Num);
        }
    }
}
