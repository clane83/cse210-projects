using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main st", "Las Vegas", "NV", "USA");
        Customer customer1 = new Customer("Bailey", address1);
        System.Console.WriteLine(customer1.DisplayCustomer());


        Product product1 = new Product("Lipstick", 123, 15.99, 1);
        Product product2 = new Product("eyeshadow", 465, 5.99, 2);
        Order order1 = new Order(customer1, product1, product2);
        System.Console.WriteLine(product1.GetProductTotal());
        System.Console.WriteLine(product2.GetProductTotal());
        System.Console.WriteLine($"Your subtotal is: ${order1.GetOrderSubTotal()}");
        System.Console.WriteLine($"Your shipping total is: ${order1.GetShippingCost()}");
        System.Console.WriteLine($"Your total is: ${order1.GetOrderTotal()}");


    }
}