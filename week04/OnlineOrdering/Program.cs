using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 West Street", "Cool Town", "Cool State", "USA");
        Customer customer = new Customer("Mr. Cool Guy", address);

        Product productOne = new Product("Baseball Bat", 123456789, 30.99, 2);
        Product productTwo = new Product("Shiny Spoon", 987654321, 4.49, 5);
        Product productThree = new Product("Toy Plane", 135798642, 59.99, 3);

        Order order = new Order(customer);

        order.AddProduct(productOne);
        order.AddProduct(productTwo);
        order.AddProduct(productThree);

        Console.Clear();

        Console.WriteLine("ORDER ONE:");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());

        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order.ShippingLabel());

        Console.WriteLine("Total: ");
        Console.WriteLine(order.CartTotal().ToString("C"));
        Console.WriteLine();

        Address addressTwo = new Address("932 Canada Road", "Canada Town", "Canada Province", "Canada");
        Customer customerTwo = new Customer("Mr. Canada Guy", addressTwo);

        Product productFour = new Product("Hockey Stick", 938472638, 89.99, 1);
        Product productFive = new Product("Snow Shovel", 804859289, 12.50, 2);
        Product productSix = new Product("Toy Moose", 448294745, 19.99, 3);

        Order orderTwo = new Order(customerTwo);

        orderTwo.AddProduct(productFour);
        orderTwo.AddProduct(productFive);
        orderTwo.AddProduct(productSix);

        Console.WriteLine("ORDER TWO:");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(orderTwo.PackingLabel());

        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(orderTwo.ShippingLabel());

        Console.WriteLine("Total: ");
        Console.WriteLine(orderTwo.CartTotal().ToString("C"));
    }
}