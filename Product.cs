using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreDataAnalysis
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product (string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
