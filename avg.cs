using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class avg
    {
        static void Main()
        {
            float[] a;
            a = new float[100];
            int i, n;double sum = 0.0, avg;
            Console.WriteLine("enter no.of elements");
            n = Int32.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                Console.WriteLine("enter elements", i + 1);
                a[i]=Int32.Parse(Console.ReadLine());
                sum = sum + a[i];
            }
            avg = sum / n;
            Console.WriteLine("avg={0}", avg);





        }
    }
}
