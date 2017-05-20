using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class fib
    {
        static void Main()
        {
            int a = 0, b = 1;
            Console.WriteLine("enter a number");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("a:{0}", a);
            Console.WriteLine("b:{0}", b);
            for(int i=2;i<=num;i++)
            {
                int c = a + b;
                Console.WriteLine("c:{0}", c);
                a = b;
                b = c;
            }
        }
        

    }
}
