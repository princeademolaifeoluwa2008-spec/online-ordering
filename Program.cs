using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA Customer
        Address address1 = new Address("123 Maple Street", "Provo", "UT", "USA");
        Customer customer1 = new Customer("David Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "KEY789", 75.00, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Order 2 - International Customer (Nigeria)
        Address address2 = new Address("15 Allen Avenue", "Ikeja", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Ada Okafor", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "PHO111", 599.99, 1));
        order2.AddProduct(new Product("Charger", "CHA222", 19.99, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
