using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Console.WriteLine();

        // First order - USA customer
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        // Add some products to order 1
        Product laptop = new Product("Laptop", "LAP001", 999.99m, 1);
        Product mouse = new Product("Mouse", "MSE001", 25.50m, 2);
        Product keyboard = new Product("Keyboard", "KEY001", 75.00m, 1);

        order1.AddProduct(laptop);
        order1.AddProduct(mouse);
        order1.AddProduct(keyboard);

        // Second order - Canada customer  
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);
        Order order2 = new Order(customer2);

        // Add products to order 2
        Product phone = new Product("Smartphone", "PHN001", 699.99m, 1);
        Product phoneCase = new Product("Phone Case", "CAS001", 19.99m, 1);

        order2.AddProduct(phone);
        order2.AddProduct(phoneCase);

        // Display Order 1 information
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        // Display Order 2 information
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine();
        
        Console.WriteLine("Done!");
    }
}