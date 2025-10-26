using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreDataAnalysis.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name, List<Order> orders)
        {
            Name = name;
            Orders = orders;
        }

    }

}
