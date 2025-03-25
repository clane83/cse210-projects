using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main st", "Las Vegas", "NV", "USA");
        Customer customer1 = new Customer("Bailey", address1);
        System.Console.WriteLine(customer1.DisplayCustomer());

    }
}