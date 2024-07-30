using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }

    class TestCustomer
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();

            Customer c1 = new Customer
            {
                Custid = 1,
                Name = "Abhishek",
                City = "Delhi",
                Balance = 34440.00
            };

            Customer c2 = new Customer
            {
                Custid = 2,
                Name = "Aman",
                City = "Bangalore",
                Balance = 43000.00
            };

            Customer c3 = new Customer
            {
                Custid = 3,
                Name = "Neha",
                City = "Uttar Pradesh",
                Balance = 54000.00
            };

            Customer c4 = new Customer
            {
                Custid = 4,
                Name = "Lokesh",
                City = "Faridabad",
                Balance = 29000.00
            };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);

            foreach (Customer obj in Customers)
            {
                Console.WriteLine($"{obj.Custid} {obj.Name} {obj.City} {obj.Balance}");
            }
            Console.ReadLine();
        }
    }
}
