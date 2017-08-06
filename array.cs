using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class array
    {
        public static void Main()
        {
            int[] intarray;
            intarray = new int[5] { 1, 2, 3, 4 ,5}; //initialising Array
            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[1]);
            Console.WriteLine(intarray[2]);
            foreach(int b in intarray)
            {
                Console.WriteLine(b);
            }
            int[,] numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };  // initialising Two Dimensional Array
            foreach(int c in numbers)
            {
                Console.WriteLine(c);
            }
           
        }
        

    }
}
