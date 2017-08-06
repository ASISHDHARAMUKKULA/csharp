using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class EncapsulationDemo
    {
        int x;
        EncapsulationDemo(int ix)
        {
            this.x = ix;

        }
        public void square()
        {
            int cal = x * x;
            Console.WriteLine(cal);
        }
        static void Main()
        {
            EncapsulationDemo d = new EncapsulationDemo(10);
            d.square();
        }

    }
}



Encapsulation is the mechanism that binds together the code and the data it manipulates, and keeps both safe from outside interference and misuse. In OOP, code and data may be combined in such a way that a self-contained box is created. When code and data are linked together in this way, an object is created and encapsulation exists.

Within an object, code, data or both may be private or public to that object. Private code is known to and accessible only by another part of the object, that is private code or data may not be accessible by a piece of the program that exists outside the object. When the code and data is public, other portions of your program may access it even though it is defined within an object.
