using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class leap
    {
        static void Main()
        {
            Console.WriteLine("enter a  year");
            int year = Int32.Parse(Console.ReadLine());
            if(year%400==0)
            {
                Console.WriteLine("Leapyear");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
        

    }
}
