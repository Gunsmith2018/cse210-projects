using System;

class Program
{
    static void Main(string[] args)
    {
        // THe User will be asked for their name and where they live
        Console.WriteLine("Welcome to the ordering system.");

        Console.Write("What is your Name: ");
        string name = Console.ReadLine();


        Console.Write("Entre your Street Address: ");
        string street = Console.ReadLine();

        Console.WriteLine("Enter your City name: ");
        string city = Console.ReadLine();

        Console.WriteLine("Enter what state you live in: ");
        string state = Console.ReadLine();

        Console.WriteLine("Enter your Country (If you live in the USA, type United States): ");
        string country = Console.ReadLine();

        // Combinding the user's info for shipping details
        Address userAddress = new Address(street, city, state, country);
        Customer userCustomer = new Customer(name, userAddress);

        // Hard Coded products. In proper form, having a few more classes for products would be better than this method.
        Product p1 = new Product("Laptop", "A100", 999.99);
        Product p2 = new Product("Mouse", "B200", 20.00);
        Product p3 = new Product("Keyboard", "C300", 259.99);

        //creating user order form
        Order userOrder = new Order(userCustomer);

        userOrder.AddProduct(p1);
        userOrder.AddProduct(p2);
        userOrder.AddProduct(p3);

        //Displaying user inputs and products.
        //Packing Label
        Console.WriteLine("\n--- PACKING LAVEL ---");
        Console.WriteLine(userOrder.GetPackingLabel());
        //Shipping Label
        Console.WriteLine("--- Shipping Label ---");
        Console.WriteLine(userOrder.GetShippingLabel());
        // Total Cost
        Console.WriteLine($"Total Cost: ${userOrder.GetTotalCost()}");






    }
}