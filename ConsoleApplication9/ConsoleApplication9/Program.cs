using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {  

            int a = 0;
            int b = 1;
            for (int j = 0; j < 100; j++)
            {
                int temp = a + b;
                Console.WriteLine(temp);
                for (int i = 0; i < 100; i++)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
            }
        }
    }
}
