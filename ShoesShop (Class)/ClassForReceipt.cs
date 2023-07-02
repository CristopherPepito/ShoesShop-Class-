using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop__Class_
{
    internal class OrderForMen
    {
        public string name;
        public int quantity;
        public int price;
        public string size;

        public OrderForMen(string name, int quantity, string size, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.size = size;
        }
    }
    internal class OrderForWomen
    {
        public string name;
        public int quantity;
        public int price;
        public string size;

        public OrderForWomen(string name, int quantity, string size, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.size = size;
        }
    }
    internal class OrderForKids
    {
        public string name;
        public int quantity;
        public int price;
        public string size;

        public OrderForKids(string name, int quantity, string size, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.size = size;
        }
    }
}
