using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class foreachex
    {
        static void Main()
        {
            int[] a = new int[5];
            int sum= 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("enter value for {0} element",i);
                a[i] = Int32.Parse(Console.ReadLine());
                sum = sum + a[i];
            }
            Console.WriteLine("sum={0}", sum);
            int avg = sum / a.Length;
            foreach(int n in a)
            {
                if (n > avg)
                    Console.WriteLine(n);

            }
        }
    }
}
