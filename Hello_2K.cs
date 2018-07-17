using System;
using System.Diagnostics;
using System.Threading;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
                for(int i=0; i<2000; i++)
                {
                        Thread.Sleep(5000);
                        Console.WriteLine("Hello World!");
                }
        }

        }
}
