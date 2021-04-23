using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ConsoleApplication4
{
    class Program
    {
        void task1()
        {
          for(int i=1;i<10;i++)
          {
            Thread. Sleep(1000);
           Console.WriteLine("task1 "+i);
           
         }
        }
        
        static void Main()
        {
              //creating object
              Program p=new Program();
              
              //creating thread objects for member functions
              Thread t1= new Thread(new ThreadStart(p.task1));
              
              //displaying thread state for t1 before starting thread
              Console.WriteLine("Thread state "+t1.ThreadState);
              
              t1.Start();    //starting thread
              Console.WriteLine("Thread state "+t1.ThreadState);
              
              t1.Suspend();  //stoping t1 thread for some time
              Console.WriteLine("Thread State "+t1.ThreadState);
              
              t1.Resume();   //again resuming the thread
              Console.WriteLine("Thread state "+t1.ThreadState);
              
              t1.Abort();   //destroying t1 thread
              Console.WriteLine("Thread state "+t1.ThreadState);
              
        }
    }
}
