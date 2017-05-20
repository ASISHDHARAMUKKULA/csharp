using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asishcsharp
{
    class product
    {
        private string name;
        private int price;
        public product(string name,int price)
        {
            this.price = price;
            this.name = name;
           

        }
        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(price);
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }
        public int Netprice
        {
            get
            {
                return price + price * 12 / 100;
            }
           
        }
    }
    class testproduct
    {
        static void Main()
        {
            product p;
            p = new product("Iphone",70000);
            p.Print();
            p.Price = 50000;
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Netprice);
        }
    }
}
