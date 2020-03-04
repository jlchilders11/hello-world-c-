using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string s in args)
            {
                Console.WriteLine("{0}", s);
            }
        }
    }
}
