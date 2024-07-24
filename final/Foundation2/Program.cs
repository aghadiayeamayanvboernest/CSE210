using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ernesto Accessories");
        Console.WriteLine();

        // Create some products
        
        Product product1 = new Product("Laptop", "LAP123", 999.99m, 1);
        Product product2 = new Product("Mouse", "MOU456", 19.99m, 2);
        Product product3 = new Product("Keyboard", "KEY789", 49.99m, 1);
        Product product4 = new Product("Monitor", "MON012", 199.99m, 1);
        Product product5 = new Product("Printer", "PRI345", 129.99m, 1);

        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Lagos", "LA", "Nigeria");
        Address address4 = new Address("101 Pine St", "Abuja", "FC", "Nigeria");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Chinedu Okafor", address3);
        Customer customer4 = new Customer("Amina Yusuf", address4);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product4);

        Order order4 = new Order(customer4);
        order4.AddProduct(product4);
        order4.AddProduct(product5);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost()}\n");

        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order4.GetTotalCost()}\n");
    }
}
