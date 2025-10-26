﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreDataAnalysis.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }


        public Order (int orderId, List<Product> products)
        {
            OrderId = orderId;
            Products = products;
        }
    }
}
