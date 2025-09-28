using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        Address address1 = new Address("123 E 456 N", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("987 W 654 S", "Ottawa", "ON", "CA");

        Customer customer1 = new Customer("Jane Doe", address1);
        Customer customer2 = new Customer("John Doe", address2);

        Product product1 = new Product("Chocolate", "123-a57", 2.99, 5);
        Product product2 = new Product("Book", "908-g64", 29.50, 2);
        Product product3 = new Product("TV", "037-c75", 598.99, 1);
        Product product4 = new Product("PS5", "298-j84", 499.00, 1);
        Product product5 = new Product("Containers", "165-d71", 12.87, 6);

        Order order1 = new Order(customer1, product1, product2, product3);
        Order order2 = new Order(customer2, product4, product5);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder Total: ${order1.CalculateTotalCost()}\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder Total: ${order2.CalculateTotalCost()}\n");
    }
}