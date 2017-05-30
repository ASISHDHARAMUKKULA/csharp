using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class Thisdemo
    {
        private int a,  b;
        public Thisdemo(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public  void Print()
        {
            Console.WriteLine(this.a);
            Console.WriteLine(this.b);
        }

    }
    class Demo
    {
        public static void Main()
        {
            Thisdemo t = new Thisdemo(10, 20);
            Thisdemo b = new Thisdemo(11, 22);
            t.Print();
            
        }
    }
}
