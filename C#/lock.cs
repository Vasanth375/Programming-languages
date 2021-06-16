using System;
using System.Threading;
namespace ConsoleApplication4
{
    class ThreadX
    {
        public void Run()
        {
            lock (this)//lock method is used to excecute only one thread at a time does not make any mutual exclusiom
            {//this keyword is whatever thread comes here while excecution no another thread would come here  
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Task is running");
                    Console.WriteLine(Thread.CurrentThread.Name);//prints the name of current running thread 
                    Thread.Sleep(1000);//takes one second to print another statement
                }
            }
        }
        static void Main(string[] args)
        {
           
            ThreadX t1 = new ThreadX();//creating object for threadx class
            Thread t2 = new Thread(t1.Run);//creating thread and the run() of threadx class is connected to t2 thread
            Thread t3 = new Thread(t1.Run);//create another thread and the same run() of threadx class is connected to t3 thread
            t2.Name = "t1";//setting name of t2 thread is as t1
            t3.Name = "t2";//setting name of t3 thread is as r2
            t2.Start();//starting t2 thread
            t3.Start();//starting t3 thread

            Console.ReadKey();
        }
    }
}
