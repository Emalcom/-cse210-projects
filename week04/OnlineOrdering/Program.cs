using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address(" 123 Main st", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("4556 Maple Ave", "Toronto","ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "K789", 49.99, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P123", 799.99, 1));
        order2.AddProduct(new Product("Charger", "C456", 19.99, 1));

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${ order.GetTotalCost():0.00}");
        Console.WriteLine(new string ('-', 40));
    }
}