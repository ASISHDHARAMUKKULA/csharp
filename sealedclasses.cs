using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    sealed class SealedClasses
    {
        public void MyFun()
        {

        }
    }
    public class Test:SealedClasses
    {
        static void Main()
        {
            SealedClasses s = new SealedClasses();
            s.MyFun();
        }
    }
}


This program will not return because Sealedclasses cannot be inherited.


Sealed classes are the reverse of abstract classes. 
While abstract classes are inherited and are refined in the derived class, sealed classes cannot be inherited. 
You can create an instance of a sealed class. 
A sealed class is used to prevent further refinement through inheritance. 
