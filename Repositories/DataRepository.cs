using System;
using System.Collections.Generic;
using System.Xml.Linq;
using OnlineStoreDataAnalysis.Models;

namespace OnlineStoreDataAnalysis.Repositories
{
    public class DataRepository
    {
        private List<Product> _products;
        private List<Customer> _customers;

        public DataRepository()
        {
            _products = new List<Product>
            {
                new Product("Sting Sword", 120.0, 1),
                new Product("Mithril Armor", 500.0, 1),
                new Product("Elven Bow", 150.0, 1),
                new Product("Lembas Bread", 10.0, 5),
                new Product("Anduril Sword", 200.0, 1),
                new Product("Gondor Shield", 100.0, 1),
                new Product("Healing Potion", 25.0, 2),
                new Product("Ranger Cloak", 50.0, 1),
                new Product("Wizard Staff", 300.0, 1)
            };

            var order1 = new Order(1, new List<Product> { _products[1], _products[5] });
            var order2 = new Order(2, new List<Product> { _products[0], _products[3] }); 

            _customers = new List<Customer>
            {
                new Customer("Gimli", new List<Order> { order1 }),
                new Customer("Bilbo", new List<Order> { order2 }),
                new Customer("Legolas", new List<Order> { order1, order2 })
            };


        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductByName(string nameInput)
        {
            return _products.FirstOrDefault(p => p.ProductName == nameInput);
        }

        public List<Order> GetAllOrders()
        {
            return _customers.SelectMany(c => c.Orders)
                            .ToList();
        }

        public List<Order> GetOrdersByCustomer(string customerName)
        {
            return _customers.Where(w => w.Name == customerName)
                             .SelectMany(w => w.Orders)
                             .ToList();
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }
    }
}
