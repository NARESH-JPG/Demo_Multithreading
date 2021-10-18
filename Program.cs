using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Demo_MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Multitasking using MultiThreading in C# ");
            MyClass History = new MyClass();
            Console.WriteLine("main thread start....!!");
            History.Display();



            //creating a ref of Threadstart
            ThreadStart Th1 = History.Display;
            ThreadStart Th2 = History.Read;
            //Creating Instance of Thread Class
            Thread s1 = new Thread(Th1);
            Thread s2 = new Thread(Th2);
            
            s1.Start();
            s2.Start();

            Console.WriteLine("Main Thread ends here.....!!!");
            Console.ReadKey();



        }

    }
}
