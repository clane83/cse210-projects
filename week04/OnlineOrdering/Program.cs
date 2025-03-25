using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main st", "Las Vegas", "NV", "USA");
        Console.WriteLine(address1.GetAddress());

    }
}