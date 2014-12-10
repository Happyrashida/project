using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("Hi buddy! Please enter your name:");
            userName = Console.ReadLine();

            Console.WriteLine("Hello {0}! Good morning...", userName);
        }
    }
}
