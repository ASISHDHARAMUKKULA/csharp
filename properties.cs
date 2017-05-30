using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class Propertiesdemo
    {
        private int hour, min=10, sec=5;
        
        public int Hours
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value <= 23)
                    hour = value;
            }
        }
        public int TotalSeconds
        {
            get
            {
                return hour * 3600 + min * 60 + sec;
            }
        }
    }
        class Time
    {
        public static void Main()
        {

            Propertiesdemo pd = new Propertiesdemo();
            
                pd.Hours = 20;
                
           

            
            if (pd.Hours > 12)
                Console.WriteLine("totalseconds={0}", pd.TotalSeconds);
        }
    }
}
