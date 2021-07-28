using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class student
    {
        public
            int[] num = new int[5];

        public int this[int i]
        {
            set
            {
                num[i] = value;
            }
            get
            {
                return num[i];
            }
            
        }
     
        public void display(student s,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(s[i]);
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
            for(int i=0;i<5;i++)
            {
                obj[i] = i + 1 ;
            }
            
            
            obj.display(obj,5);

            //Console.ReadKey();
        }
    }
}
