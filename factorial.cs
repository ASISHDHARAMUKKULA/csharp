using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class factorial
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(args[0]);
           
            int fact = 1;
            for (int i = 1; i <= num; i++)
                fact = fact * i;
            Console.WriteLine("factorial of {0} is {1}", num, fact);
        }
    }
}
