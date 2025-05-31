using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "N100", 3.50, 5));
        order1.AddProduct(new Product("Pen", "P200", 1.25, 10));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalCost());
        Console.WriteLine();

        // Second Order
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "T300", 150.00, 1));
        order2.AddProduct(new Product("Stylus", "S400", 25.00, 2));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalCost());
    }
}
