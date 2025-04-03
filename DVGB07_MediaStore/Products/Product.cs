using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    internal abstract class Product
    {
        public int PID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product(int pid, string name, int price, int stock)
        {
            PID = pid;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
