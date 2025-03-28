using System;

class Program
{
    static void Main(string[] args)
    {   Console.Clear();
        
        //order 1
        Address address1 = new Address("123 Main st", "Las Vegas", "NV", "USA");
        Customer customer1 = new Customer("Bailey", address1);
        // System.Console.WriteLine(customer1.DisplayCustomer());


        Product product1 = new Product("Lipstick", 123, 15.99, 1);
        Product product2 = new Product("eyeshadow", 465, 5.99, 2);
        Order order1 = new Order(customer1, product1, product2);
        // System.Console.WriteLine(product1.GetProductTotal());
        // System.Console.WriteLine(product2.GetProductTotal());
        System.Console.WriteLine(order1.GetShippingLabel());
        System.Console.WriteLine(order1.GetPackingLabel());
        System.Console.WriteLine($"Your subtotal is: ${order1.GetOrderSubTotal()}");
        System.Console.WriteLine($"Your shipping total is: ${order1.GetShippingCost()}");
        System.Console.WriteLine($"Your total is: ${order1.GetOrderTotal()}");
        System.Console.WriteLine("");
        System.Console.WriteLine("");

        //order 2
        Address address2 = new Address("33 Nine Elms Ln", "Nine Elms", "London", "United Kingdom");
        Customer customer2 = new Customer("Edward", address2);
        // System.Console.WriteLine(customer1.DisplayCustomer());


        Product product3 = new Product("How to be successful", 9878, 35.87, 1);
        Product product4 = new Product("Reading Light", 7689, 21.76, 1);
        Product product5 = new Product("Spiral Notebook", 657, 25.73, 3);
        Order order2 = new Order(customer2, product3, product4, product5);
        // System.Console.WriteLine(product1.GetProductTotal());
        // System.Console.WriteLine(product2.GetProductTotal());
        System.Console.WriteLine(order2.GetShippingLabel());
        System.Console.WriteLine(order2.GetPackingLabel());
        System.Console.WriteLine($"Your subtotal is: ${order2.GetOrderSubTotal()}");
        System.Console.WriteLine($"Your shipping total is: ${order2.GetShippingCost()}");
        System.Console.WriteLine($"Your total is: ${order2.GetOrderTotal()}");
        System.Console.WriteLine("");
        System.Console.WriteLine("");

        //order 2
        Address address3 = new Address("490 Sussex Drive", "Ottawa", "Ontario", "Canada");
        Customer customer3 = new Customer("Melanie", address3);
        // System.Console.WriteLine(customer1.DisplayCustomer());


        
        Order order3 = new Order(customer3, product1, product3, product5);
        // System.Console.WriteLine(product1.GetProductTotal());
        // System.Console.WriteLine(product2.GetProductTotal());
        System.Console.WriteLine(order3.GetShippingLabel());
        System.Console.WriteLine(order3.GetPackingLabel());
        System.Console.WriteLine($"Your subtotal is: ${order3.GetOrderSubTotal()}");
        System.Console.WriteLine($"Your shipping total is: ${order3.GetShippingCost()}");
        System.Console.WriteLine($"Your total is: ${order3.GetOrderTotal()}");
        System.Console.WriteLine("");
        System.Console.WriteLine("");
    }
}